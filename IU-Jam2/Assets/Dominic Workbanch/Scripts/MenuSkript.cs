using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// namespace for scene change
using UnityEngine.SceneManagement;

public class MenuSkript : MonoBehaviour
{
    public GameObject CreditScreen;
    public GameObject ControlScreen;

    public AudioSource MenuSound;
    
    // Start is called before the first frame update
    void Start()
    {
        CreditScreen.SetActive(false);
        print("Deaktiviert");

        ControlScreen.SetActive(false);
        print("Control Deactiviert");

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
// HideCredits();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField] Slider volumeSlider;

    public void PlayGame()
    {
        menuSoundStop();
        SceneManager.LoadScene("0 Outside"); // load scene with name
    }

    public void ShowCredits()
    {
        CreditScreen.SetActive(true);
        print("Show Credits");
    }

    public void HideCredits()
    {
        CreditScreen.SetActive(false);
    }

    public void ShowControls()
    {
        ControlScreen.SetActive(true);
    }

    public void HideControls()
    {
        ControlScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    private void menuSoundStop()
    {
        MenuSound.Stop();
    }
}
