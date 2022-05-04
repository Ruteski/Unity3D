using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Teste");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Teste() {
        //Debug.Log("executando corrotina");
        ////yield return null;
        //yield return new WaitForSeconds(5f);
        //Debug.Log("executando após waitforseconds");

        yield return new WaitForSeconds(3);
        Color color = Color.red;

        GetComponent<MeshRenderer>().material.color = color;
    }
}
