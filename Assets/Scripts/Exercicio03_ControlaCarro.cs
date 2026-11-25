using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio03_ControlaCarro : MonoBehaviour
{
    public float _movimento;

    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            this.transform.Translate(0, 0, _movimento);
        }

        if(Input.GetKeyUp("s"))
        {
            this.transform.Translate(0, 0, -_movimento);
        }

        if(Input.GetKey("a"))
        {
            this.transform.Translate(-_movimento, 0, 0);
        }

        if(Input.GetKeyDown("d"))
        {
            this.transform.Translate(_movimento, 0, 0);
        }
    }
}
