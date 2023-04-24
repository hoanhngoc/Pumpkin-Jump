using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class trap : MonoBehaviour
{
    private GameController controller;                  
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();
       

    }


    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 10f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            controller.GameOVer();
        }
      

    }
   

}
    
        
