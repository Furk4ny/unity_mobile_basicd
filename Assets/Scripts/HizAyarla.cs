using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HizAyarla : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    public Rigidbody2D rg;
    void Start()
    {
        rg = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = new Vector2(0, -hiz * Time.deltaTime);
    }
}
