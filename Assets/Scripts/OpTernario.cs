using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpTernario : MonoBehaviour
{
    public int life;

    void Start()
    {
        Debug.Log(life > 0 ? "Player esta vivo" : "Player esta morto");

        Sobrecarga sob = new Sobrecarga();

        sob.Add(10,20);
        sob.Add("teste1","teste2");
    }

}
