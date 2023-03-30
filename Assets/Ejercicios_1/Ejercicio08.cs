using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio08 : MonoBehaviour
    {
        private void Start()
        {
            GameObject cubo;
            for (int i = 1; i <= 3; i++)
            {
                cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubo.transform.localScale = Vector3.one * i;
            }
        }
    }
}