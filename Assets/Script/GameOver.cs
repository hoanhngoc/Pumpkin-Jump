using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private GameController gameController;
    private GameObject animal;
    // Start is called before the first frame update
    void Start()
    {
       gameController= FindObjectOfType<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animal = GameObject.FindGameObjectWithTag("animal");
        if(animal == null)
        {
            gameController.GameOVer();
        }
    }
}
