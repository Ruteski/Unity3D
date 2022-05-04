using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    public MyCharacter[] Chars;

    // Start is called before the first frame update
    void Start()
    {
        Chars = new MyCharacter[2];

        Chars[0] = new MyCharacter();
        Chars[1] = new OrcCharacter();

        EnterTavern();
    }

    public void EnterTavern(){
        foreach(MyCharacter c in Chars) {
            c.Say();
        }
    }

}
