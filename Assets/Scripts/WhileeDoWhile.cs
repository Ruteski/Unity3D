using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileeDoWhile : MonoBehaviour
{
    int itensCena = 5;
    int itensCena2 = 5;
    int valor = 500;

    // Start is called before the first frame update
    void Start()
    {
        while( itensCena-- > 0 ) {
            Debug.Log("itensCena"  + itensCena);
        }

        while (itensCena2 > 0) {
            Debug.Log("itensCena2" + itensCena2);
            itensCena2--;
        }

        do {
            Debug.Log(valor);
            valor -= 50;
        } while (valor > 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
