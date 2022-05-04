using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateRotation : MonoBehaviour
{

    public float velocidade = 5f;
    public float rotacao = 55f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Time.deltaTime * velocidade * Vector3.forward);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Time.deltaTime * velocidade * Vector3.back);
        }

        //if (Input.GetKey(KeyCode.RightArrow)) {
        //    transform.Translate(Time.deltaTime * velocidade * Vector3.right);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow)) {
        //    transform.Translate(Time.deltaTime * velocidade * Vector3.left);
        //}

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(rotacao * Time.deltaTime * Vector3.up);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(rotacao * Time.deltaTime * Vector3.down);
        }
    }
}
