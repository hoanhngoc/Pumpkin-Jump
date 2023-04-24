using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetting : MonoBehaviour
{

    [SerializeField] GameObject AboutUsmenu;
    [SerializeField] GameObject Abooutgamemenu;
    public string scenetoload;
    // Start is called before the first frame update
    void Start()
    {
        AboutUsmenu.SetActive(false);
        Abooutgamemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene(scenetoload);
    }
    public void Aboutus()
    {
        AboutUsmenu.SetActive(true);
    }
    public void CloseAboutus()
    {
        AboutUsmenu.SetActive(false);
    }
    public void Aboutgame()
    {
        Abooutgamemenu.SetActive(true);
    }
    public void CloseAboutGame()
    {
        Abooutgamemenu.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
