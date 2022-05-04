using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POO : MonoBehaviour
{
    public class Personagem {
        private string name;
        private int life;
        private int age;

        public Personagem(string name, int life, int age) {
            this.name = name;
            this.life = life;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Life { get => life; set => life = value; }
        public int Age { get => age; set => age = value; }

        public void AumentarVida() {
            life++;
        }
    }

    Personagem p1 = new Personagem("personagem 1", 20, 15);
}
