using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sobrecarga : MonoBehaviour
{
    public int Add(int n1, int n2) {
        return n1* n2;
    }

    public string Add(string s1, string s2) {
        return s1 + "  " + s2;    
    }



}
