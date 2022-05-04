using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulamento : MonoBehaviour
{
    public class Warrior {
        private int health;
        private string name;
        private string description;

        public Warrior(int health, string name, string description) {
            Health = health;
            Name = name;
            Description = description;
        }

        public int Health { 
            get => health; 
            set {
                health -= value;

                if (health <= 0) { 
                    health = 0;
                    Die();
                }
            }
        }

        private void Die() {
            //personagem morreu
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
