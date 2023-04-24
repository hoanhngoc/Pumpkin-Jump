using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject GameOverMenu;
    [SerializeField] GameObject ShopButton;
    [SerializeField] GameObject Shopmenu;
    [SerializeField] GameObject pausegamemenu;
    [SerializeField]
    private string _SceneName;



    // Start is called before the first frame update
    void Start()
    {
        PauseButton.SetActive(true);
        ShopButton.SetActive(true);
        pausegamemenu.SetActive(false);
        GameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PauseGame()
    {

        PauseButton.SetActive(false);
        ShopButton.SetActive(false);  
        pausegamemenu.SetActive(true); 
        Time.timeScale = 0f;

    }
    public void ClosePause()
    {
        PauseButton.SetActive(true);
        pausegamemenu.SetActive(false);
        ShopButton.SetActive(true);
        Time.timeScale = 1f;
    }


    public void ShopmenuOpen()
    {
        PauseButton.SetActive(false);
        ShopButton.SetActive(false);
        Shopmenu.SetActive(true); 
        Time.timeScale = 0f;
    }

    public void CloseShop()
    {
        ShopButton.SetActive(true);
        PauseButton.SetActive(true);
        Shopmenu.SetActive(false);
        Time.timeScale = 1f; 
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    //load again map
    public void Playagain()
    {
       
        SceneManager.LoadScene(_SceneName);
        Time.timeScale = 1f;
    }

    public void GameOVer()
    {
       
        GameOverMenu.SetActive(true);
      
        Time.timeScale=0f;
    }
    public void Playcontinue()
    {
        Time.timeScale = 1f;
        pausegamemenu.SetActive(false); ;
        PauseButton.SetActive(true);
        ShopButton.SetActive(true);

    }
    public void backtomenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f; 
    }
}
