using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio09_ControlaCarro : MonoBehaviour
{
    public float _velocidade;
    private GameObject rodaA;
    private GameObject rodaB;
    private GameObject rodaC;
    private GameObject rodaD;

    private GameObject camPrimeiraPessoa;
    private GameObject camTerceiraPessoa;

    void Start()
    {
        rodaA = transform.Find("Roda_A").gameObject;
        rodaB = transform.Find("Roda_B").gameObject;
        rodaC = transform.Find("Roda_C").gameObject;
        rodaD = transform.Find("Roda_D").gameObject;

        camPrimeiraPessoa = transform.Find("CameraPrimeiraPessoa").gameObject;
        camTerceiraPessoa = transform.Find("CameraTerceiraPessoa").gameObject;
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Translate(0, 0, _velocidade * Time.deltaTime);

            rodaA.transform.Rotate(_velocidade, 0, 0);
            rodaB.transform.Rotate(_velocidade, 0, 0);
            rodaC.transform.Rotate(_velocidade, 0, 0);
            rodaD.transform.Rotate(_velocidade, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            this.transform.Translate(0, 0, -_velocidade * Time.deltaTime);

            rodaA.transform.Rotate(-_velocidade, 0, 0);
            rodaB.transform.Rotate(-_velocidade, 0, 0);
            rodaC.transform.Rotate(-_velocidade, 0, 0);
            rodaD.transform.Rotate(-_velocidade, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Translate(-_velocidade * Time.deltaTime, 0, 0);

            rodaA.transform.Rotate(0, 0, _velocidade);
            rodaB.transform.Rotate(0, 0, _velocidade);
            rodaC.transform.Rotate(0, 0, _velocidade);
            rodaD.transform.Rotate(0, 0, _velocidade);
        }

        if (Input.GetKey("d"))
        {
            this.transform.Translate(_velocidade * Time.deltaTime, 0, 0);

            rodaA.transform.Rotate(0, 0, -_velocidade);
            rodaB.transform.Rotate(0, 0, -_velocidade);
            rodaC.transform.Rotate(0, 0, -_velocidade);
            rodaD.transform.Rotate(0, 0, -_velocidade);
        }

        if (Input.GetKeyDown("space"))
        {
            //this.transform.Translate(0, 10, 0); //sem trajetória
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 900f); //com trajetória
        }

        if(Input.GetKey("1"))
        {
            camPrimeiraPessoa.SetActive(true);
            camTerceiraPessoa.SetActive(false);
        }

        if (Input.GetKey("3"))
        {
            camPrimeiraPessoa.SetActive(false);
            camTerceiraPessoa.SetActive(true);
        }

    }
}
