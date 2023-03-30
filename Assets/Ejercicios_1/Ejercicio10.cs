using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio10 : MonoBehaviour
    {
        private void Start()
        {
            GameObject[] objetos = GameObject.FindObjectsOfType<GameObject>();
            for (int i = 0; i < objetos.Length; i++)
            {
                objetos[i].name = "Este es el GameObjecto numero: " + (i + 1);
            }
        }
    }
}