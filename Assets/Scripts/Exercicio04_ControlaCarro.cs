using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio04_ControlaCarro : MonoBehaviour
{
    public float _velocidade;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Translate(0, 0, _velocidade * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            this.transform.Translate(0, 0, -_velocidade * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Translate(-_velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            this.transform.Translate(_velocidade * Time.deltaTime, 0, 0);
        }
    }
}
