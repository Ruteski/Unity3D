using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Ataque();
    }

    public override void Ataque() {
        //base.Ataque();
        // ataque sobrescrito
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
