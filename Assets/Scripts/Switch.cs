using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    int diaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (diaSemana) {
            case 0:
                Debug.Log("domingo");
                break;
            case 1:
                Debug.Log("segunda");
                break;
            case 3:
                Debug.Log("terça");
                break;
            case 4:
                Debug.Log("quarta");
                break;
            case 5:
                Debug.Log("quinta");
                break;
            case 6:
                Debug.Log("sexta");
                break;
            default:
                Debug.Log("fora da data");
                break;
        }  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
