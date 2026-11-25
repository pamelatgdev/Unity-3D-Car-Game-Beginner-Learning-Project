using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio01_NomeConsole : MonoBehaviour
{
    public string _nome;
    
    void Start()
    {
        Debug.Log("Executa uma vez só :0. Criado: " + _nome);
    }
    
    void Update()
    {
        Debug.Log(message: "Cada frame, eu volto! Nome: " + _nome);
    }
}
