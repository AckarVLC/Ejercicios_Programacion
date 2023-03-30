using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio06 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera2.transform.position = new Vector3(100, 0, 0);
        }
    }
}