using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesConstrutores : MonoBehaviour
{

    [System.Serializable]
    public class Cachorro {
        public string nome;
        public string raca;
        public int idade;

        public Cachorro(string nome, string raca, int idade) {
            this.nome = nome;
            this.raca = raca;  
            this.idade = idade;
        }
    }

    public Cachorro dog = new("bob", "tomba", 1);
    public Cachorro dog2 = new("thor", "pitbull", 2);

    private void Start() {
        Debug.Log(dog.nome);
        Debug.Log(dog.raca);

        Debug.Log(dog2.nome);
        Debug.Log(dog2.raca);

        // metodo estatico
        MetodosVariaveisStatic.estaticos.AumentarVida();

    }
}
