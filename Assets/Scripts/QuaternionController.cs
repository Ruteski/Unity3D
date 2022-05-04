using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionController : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Quaternion.identity);   

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(pos);
    }
}
