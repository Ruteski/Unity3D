using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    public string nome;
    public int vida;
    public int forca;
    public float velocidade;

    public virtual void Say() {
        Debug.Log("Ola meu amigo");
    }


}
