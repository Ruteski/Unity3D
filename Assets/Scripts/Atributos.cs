using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributos : MonoBehaviour
{
    [Header("variaveis numericos")]
    //[HideInInspector]//oculta variaveis publicas do inspector
    public int Score;

    [SerializeField]
    private int point;

    [Space]
    [Header("outras variaveis")]
    [Tooltip("variaveis que nao sao numericas")]
    public string nome;

    [Range(-5f, 5f)]
    public int barraVida;

    [TextArea]
    public string barra;
}
