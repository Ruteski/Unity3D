using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcCharacter : MyCharacter
{
    // Start is called before the first frame update
    void Start()
    {
        Say();
    }

    public override void Say() {
        Debug.Log("olha so quem chegou");
    }

}
