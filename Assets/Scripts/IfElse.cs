using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    int n1 = 10;
    int n2 = 9;

    // Start is called before the first frame update
    void Start()
    {
        if (Application.isPlaying) {
            //
        }

        if (n1 >= n2) {
            Debug.Log("verdadeiro");
        } else {
            Debug.Log("falso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
