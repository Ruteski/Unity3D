using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int vida = 100;

    public void Dano(int dano) {
        vida -= dano;
    }

    //possibilita este metodo a ser reescrito por classes herdadas
    public virtual void Ataque() {
        //ataque geral/comum para os inimigos
    }

   
}
