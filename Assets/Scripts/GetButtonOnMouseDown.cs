using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonOnMouseDown : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {//se manter pressionado continua true
            Debug.Log("A pressionado");
        }

        if (Input.GetKeyDown(KeyCode.B)) {// true somente quando aperta a tecla
            Debug.Log("B pressionado");
        }

        if (Input.GetKeyUp(KeyCode.C)) {// true somente quando solta a tecla
            Debug.Log("C pressionado");
        }
    }

    //acoes do mouse
    private void OnMouseDown() {
        Debug.Log("clicou");
    }
}
