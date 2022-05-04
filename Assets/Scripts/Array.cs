using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[] inimigos;
    string[] names;
    GameObject[] objects;
    Transform[] transforms;
    GameObject[] player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject p in player) {
            Debug.Log(p.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
