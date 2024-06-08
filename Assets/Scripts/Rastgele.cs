using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rastgele : MonoBehaviour
{
    public GameObject[] prefabs;
    void Start()
    {
        InvokeRepeating("olustur",0.3f,0.8f);
        InvokeRepeating("olustur1",0.3f,2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void olustur()
    {
        var x=Random.Range(-2.2f,2.2f);
        Vector3 position=new Vector3(x,10,0);
        int a =  Random.Range(1,3);
        var yeni=Instantiate(prefabs[a],position,Quaternion.identity);
    }

    void olustur1()
    {
        var x = Random.Range(-2.2f, 2.2f);
        Vector3 position = new Vector3(x, 10, 0);
        var yeni = Instantiate(prefabs[0], position, Quaternion.identity);
    }

}
