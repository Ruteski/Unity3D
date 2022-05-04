using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubo : MonoBehaviour
{
    private void Start() {
        Destroy(gameObject, 3f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            Destroy(gameObject);
        }        
    }
}
