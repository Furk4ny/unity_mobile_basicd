using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour
{
    public void OyunAc()
    {
        Application.LoadLevel("Oyun");
    }
    public void OyunAc(string ad)
    {
        SceneManager.LoadScene(ad);
    }
    public void OyunKapat()
    {
        Application.Quit();
    }
    public Text yaz;
    void Start()
    {
        yaz.text= "Rekor :" + PlayerPrefs.GetFloat("Rekor").ToString();
    }
}
