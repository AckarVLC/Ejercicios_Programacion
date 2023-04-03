using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicio08 : MonoBehaviour
    {
        private void Start()
        {
            GameObject cubo;
            for (int i = 1; i <= 3; i++)
            {
                cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubo.transform.localScale = Vector3.one * i;
                //❕ cubo.transform.localScale = Vector3.one * Mathf.Pow(2, i-1);
            }
        }
    }
}