using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dstryerGlass : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o objeto que colidiu tem a tag METAL ou PAPEL ou VIDRO
        if (collision.gameObject.tag == "METAL" || collision.gameObject.tag == "PAPEL" || collision.gameObject.tag == "VIDRO" || collision.gameObject.tag == "PLASTICO" )
        {
            // Destrói o objeto
            Destroy(this.gameObject);
        }
    }
}
