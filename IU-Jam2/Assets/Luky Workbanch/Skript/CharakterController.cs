using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterController : MonoBehaviour
{
    private Rigidbody2D rb;
    
   
    // movement variables
    private float moveH;
    private float moveV;
    [SerializeField] private float moveSpeed = 1.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * moveSpeed;

        moveV = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector2(moveH, moveV);


        //animation related
        Vector2 direction = new Vector2(moveH, moveV);

        FindObjectOfType<ChaAnimation>().SetDirection(direction);
   
    }
}
