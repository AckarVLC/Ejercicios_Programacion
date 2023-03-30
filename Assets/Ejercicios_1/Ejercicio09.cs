using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio09 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera;
            for (int i = 1; i <= 12; i++)
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.localScale = Vector3.one * i;
            }
        }
    }
}