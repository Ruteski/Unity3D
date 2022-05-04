using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosVariaveisStatic : MonoBehaviour
{
    public static MetodosVariaveisStatic estaticos;

    public int vidas = 10;

    // Start is called before the first frame update
    void Start()
    {
        estaticos = this;
    }

    public void AumentarVida() {
        vidas++;
    }
}
