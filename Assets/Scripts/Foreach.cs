using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] inimigos = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        inimigos[0] = "inimigo 1";
        inimigos[1] = "inimigo 2";
        inimigos[2] = "inimigo 3";

        foreach (string inimigo in inimigos) {
            Debug.Log(inimigo);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
