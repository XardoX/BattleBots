using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuMenager : MonoBehaviour
{
    public Button End;
    public Button Continue;
    public Button Play;
    public Button Settings;
    public Button Quit;
    public TextMeshProUGUI TurnOff;
    public Button Skip;
    public Image Background;
    public Image Tutorial;
    public Image Tutorial2;
    public TextMeshProUGUI Credits;
    //public bool ustawienia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void OnClickGame()
    {
        Background.gameObject.SetActive(false);
        Play.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
        TurnOff.gameObject.SetActive(false);
        Tutorial.gameObject.SetActive(true);
        Continue.gameObject.SetActive(true);
        Debug.Log("Grasz");
        FindObjectOfType<AudioManager>().Play("Buttons");

    }

    public void OnClickSettings()
    {
        Play.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
        TurnOff.gameObject.SetActive(false);
        Skip.gameObject.SetActive(true);
        Credits.gameObject.SetActive(true);
        Debug.Log("Ustawienia");
        FindObjectOfType<AudioManager>().Play("Buttons");

    }

    public void OnClickQuit()
    {
        Application.Quit();
        Debug.Log("Wyszedles z gry");
        FindObjectOfType<AudioManager>().Play("Buttons");

    }
    public void OnClickSkip()
    {
        Play.gameObject.SetActive(true);
        Settings.gameObject.SetActive(true);
        Quit.gameObject.SetActive(true);
        TurnOff.gameObject.SetActive(true);
        Skip.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        Debug.Log("Skipped");
        FindObjectOfType<AudioManager>().Play("Buttons");
    }
    public void OnClickContinue()
    {
        Continue.gameObject.SetActive(false);
        Tutorial.gameObject.SetActive(false);
        Tutorial2.gameObject.SetActive(true);
        End.gameObject.SetActive(true);

    }
    public void OnClickPlay()
    {
        SceneManager.LoadSceneAsync("Main");
        Debug.Log("Ladowanie kolejnej sceny");
    }
}
