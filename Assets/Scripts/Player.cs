using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float arttir=0;
    public float saydir=0;
    public Text yaz;
    public Text rekoryaz;

     void Start()
    {
        rekoryaz.text = PlayerPrefs.GetFloat("Rekor").ToString();
    }

    void Update()
    {
     
        Vector2 mousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 kendiPos=new Vector3(transform.position.x,transform.position.y,0);
        transform.position=Vector3.MoveTowards(kendiPos,new Vector3(mousePosition.x,transform.position.y,0),Time.deltaTime*arttir);

    }
    public AudioClip ses;
    public GameObject patlama;

     void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag=="kirmizi")
        {
            saydir=saydir+30;
        }
        else if(coll.gameObject.tag=="mor")
        {
            saydir = saydir +30;
        }
        else 
        {
            Instantiate(patlama, coll.gameObject.transform.position, Quaternion.identity);
            saydir =saydir+10;
        }
        AudioSource.PlayClipAtPoint(ses,coll.transform.position);
        Destroy(coll.gameObject);
        yaz.text= "Puanýnýz : " + saydir.ToString();
        if(saydir>PlayerPrefs.GetFloat("Rekor"))
        {
            PlayerPrefs.SetFloat("Rekor",saydir);
        }

    }
}
