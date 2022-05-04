using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    int vida = 0;

    // Start is called before the first frame update
    void Start()
    {
        AumentarVida();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AumentarVida() {
        vida += 10;
    }

    void DiminuiVida(int dano) {
        vida -= dano;
    }
}
