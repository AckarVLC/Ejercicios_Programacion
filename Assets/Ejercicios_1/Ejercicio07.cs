using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio07 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera;
            for (int i = 0; i < 3; i++)
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = new Vector3((i * 100), 0, 0);
            }
        }
    }
}