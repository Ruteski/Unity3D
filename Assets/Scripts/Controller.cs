using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemies;

public class Controller : MonoBehaviour
{
    private void Start() {
        Enemies.Enemies enemy_1 = new Enemies.Enemies();
        Enemies.AnotherEnemies another_1 = new Enemies.AnotherEnemies();
    }
}
