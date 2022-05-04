using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    private Rigidbody rb;
    private BoxCollider collider;

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();

        //obj.SetActive(false);
        //obj.GetComponent<Light>().enabled = false;

        if (obj.activeSelf) {
            obj.SetActive(false);
        } else {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
