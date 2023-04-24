using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    [SerializeField] TMP_Text coincount;
    [SerializeField] TMP_Text Bestcoin;
    int powercoint;
    // Start is called before the first frame update
    void Start()
    {
        powercoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coincount.text = powercoint.ToString();
        Bestcoin.text="Best  " + powercoint.ToString();
        
    }
    public void addcoin()
    {
        powercoint++;
    }
}
