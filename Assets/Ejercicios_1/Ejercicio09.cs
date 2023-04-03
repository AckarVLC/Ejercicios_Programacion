using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera;
            for (int i = 1; i <= 12; i++)
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.localScale = Vector3.one * i;
                //❕ esfera.transform.localScale = Vector3.one * Mathf.Pow(2, i-1);
            }
        }
    }
}