using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
   public void PressPrivacyPolicy(string link)
    {
        Application.OpenURL(link);  
    }
}
