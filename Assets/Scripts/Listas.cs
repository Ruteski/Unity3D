using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    public List<string> list = new List<string>();
    public List<int> valores = new List<int>();

    [System.Serializable]
    public class Inimigo {
        public string nome;
        public string descricao;
        public float velocidade;
        public int dano;

        public Inimigo(string nome, string descricao, float velocidade, int dano) {
            this.nome = nome;
            this.descricao = descricao;
            this.velocidade = velocidade;
            this.dano = dano;
        }
    }

    public List<Inimigo> inimigos = new List<Inimigo>();

    private void Start() {
        inimigos.Add(new Inimigo("bugbear", "um grande bugbear", 7f, 5));
        inimigos.Add(new Inimigo("bugurso", "traducao ridicula de bugbear", 7f, 5));
    }
}
