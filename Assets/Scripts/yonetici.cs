using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    // Start is called before the first frame update
    public bool oyundurdumu = false;

    public void oyundurdur()
    {
        if(oyundurdumu==false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    }

    public void Don()
    {
        Application.LoadLevel("Giris");
    }


}
