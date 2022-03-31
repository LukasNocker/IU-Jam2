using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharakterController : MonoBehaviour
{
    private Rigidbody2D rb;

    // baby collect variables
    WWBAnim wbbAnim0;
    WWBAnim wbbAnim1;
    WWBAnim wbbAnim2;
    WWBAnim wbbAnim3;
    WWBAnim wbbAnim4;
    WWBAnim wbbAnim5;
    WWBAnim wbbAnim6;
    WWBAnim wbbAnim7;
    WWBAnim wbbAnim8;
    WWBAnim wbbAnim9;

    public GameObject WBB0;
    public GameObject WBB1;
    public GameObject WBB2;
    public GameObject WBB3;
    public GameObject WBB4;
    public GameObject WBB5;
    public GameObject WBB6;
    public GameObject WBB7;
    public GameObject WBB8;
    public GameObject WBB9;

    //cookie collect variables 
    public int cookies = 0;
    private bool getcookie;
    GameObject cookieToDestroy;
    public UnityEngine.UI.Text CookieCounter;


    //WBB collect varibales
    public int waschbärbabys = 0;
    public bool getWBB;
    GameObject WBBToDestroy;
    public Text WBBCounter;

    // movement variables
    private float moveH;
    private float moveV;
    [SerializeField] private float moveSpeed = 1.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        wbbAnim0 = WBB0.GetComponent<WWBAnim>();
        wbbAnim1 = WBB1.GetComponent<WWBAnim>();
        wbbAnim2 = WBB2.GetComponent<WWBAnim>();
        wbbAnim3 = WBB3.GetComponent<WWBAnim>();
        wbbAnim4 = WBB4.GetComponent<WWBAnim>();
        wbbAnim5 = WBB5.GetComponent<WWBAnim>();
        wbbAnim6 = WBB6.GetComponent<WWBAnim>();
        wbbAnim7 = WBB7.GetComponent<WWBAnim>();
        wbbAnim8 = WBB8.GetComponent<WWBAnim>();
        wbbAnim9 = WBB9.GetComponent<WWBAnim>();

    }

    private void Start()
    {
        getcookie = false;

        getWBB = false;
    }
  
    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * moveSpeed;

        moveV = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector2(moveH, moveV);


        //animation related
        Vector2 direction = new Vector2(moveH, moveV);

        FindObjectOfType<ChaAnimation>().SetDirection(direction);

        wbbAnim0.SetDirection(direction);
        wbbAnim1.SetDirection(direction);
        wbbAnim2.SetDirection(direction);
        wbbAnim3.SetDirection(direction);
        wbbAnim4.SetDirection(direction);
        wbbAnim5.SetDirection(direction);
        wbbAnim6.SetDirection(direction);
        wbbAnim7.SetDirection(direction);
        wbbAnim8.SetDirection(direction);
        wbbAnim9.SetDirection(direction);


    }

    private void Update()
    {
       
       
        
        
        if(getcookie == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy(cookieToDestroy);
                cookies += 1;
                

                getcookie = false;
                
            }
       }
       
       if(getWBB == true)
       {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Destroy(WBBToDestroy);
                waschbärbabys += 1;
                cookies -= 3;

                getWBB = false;

              
            }
       }
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Cookie"))
        {
            getcookie = true;
            
            cookieToDestroy = collision.gameObject;
        }

        if (collision.CompareTag("Baby") && cookies >= 3)
        {
            getWBB = true;

            WBBToDestroy = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Cookie"))
        {
            getcookie = false;
        }
        
        if(collision.CompareTag("Baby"))
        {
            getWBB = false;
        }
    }

   

  
}
