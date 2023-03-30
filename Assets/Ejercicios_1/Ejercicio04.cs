using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio04 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody rb = esfera.AddComponent<Rigidbody>();
            rb.useGravity = false;//Para que no se caiga al vacio XD
        }
    }
}