using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuMenager : MonoBehaviour
{
    public Button Play;
    public Button Settings;
    public Button Quit;
    public TextMeshProUGUI TurnOff;
    public Button Skip;
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
        //SceneManager.LoadSceneAsync("Arena"); odkomentowac jak bedzie gotowa scena
        Debug.Log("Grasz");

    }

    public void OnClickSettings()
    {
        Play.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
        TurnOff.gameObject.SetActive(false);
        Skip.gameObject.SetActive(true);
        Debug.Log("Ustawienia");
        
    }

    public void OnClickQuit()
    {
        Application.Quit();
        Debug.Log("Wyszedles z gry");

    }
    public void OnClickSkip()
    {
        Play.gameObject.SetActive(true);
        Settings.gameObject.SetActive(true);
        Quit.gameObject.SetActive(true);
        TurnOff.gameObject.SetActive(true);
        Skip.gameObject.SetActive(false);
        Debug.Log("Skipped");
    }

}
