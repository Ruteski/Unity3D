using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerates : MonoBehaviour
{
    public enum Direcoes {
        Norte, 
        Sul, 
        Leste, 
        Oeste
    }

    public Direcoes MinhaDirecao;


    // Start is called before the first frame update
    void Start()
    {
        switch (MinhaDirecao) {
            case Direcoes.Norte:
                break;
            case Direcoes.Sul:
                break;
            case Direcoes.Leste:
                break;
            case Direcoes.Oeste:
                break;
            default:
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
