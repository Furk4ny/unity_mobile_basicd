using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DusenleriSil : MonoBehaviour
{
    public Text yaz;
    public bool gameover=false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        gameover=false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && gameover)
        {
            Time.timeScale=1;
            //SceneManager sc=new SceneManager.GetActiveScene();
            SceneManager.LoadScene("Oyun");
        }
     }
    void OnCollisionEnter2D(Collision2D other)
    {
     audioSource.Play();
     yaz.text="\r\n Game Over";
     gameover=true;
     Time.timeScale=0;
     Destroy(other.gameObject);
    }
}
