using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesControl : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource sesDosyasi;
    private float muzikSesi = 1f;

    void Start()
    {
        sesDosyasi = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        sesDosyasi.volume = muzikSesi;
    }

    public void SesAyarla(float vol)
    {
        muzikSesi = vol;
    }

}
