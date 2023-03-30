using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio05 : MonoBehaviour
    {
        private void Start()
        {
            GameObject objeto;
            for (int i = 0; i < 30; i++)
            {
                objeto = new GameObject("Ejercicio05 objeto: " + (i + 1));
            }
        }
    }
}

