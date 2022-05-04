using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInstantiateDestroy : MonoBehaviour
{
    public GameObject prefab;
    public GameObject pai;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A)) {
        //    Instantiate(prefab);
        //}

        //if (Input.GetKeyDown(KeyCode.A)) {
        //    Instantiate(prefab, transform.position, Quaternion.identity);
        //}

        if (Input.GetKeyDown(KeyCode.A)) {
            Instantiate(prefab, pai.transform.position, pai.transform.rotation);
        }

    }
}
