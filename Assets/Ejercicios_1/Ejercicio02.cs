using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio02 : MonoBehaviour
    {
        private void Start()
        {
            GameObject objeto = new GameObject("Ejercicio02");
            objeto.transform.position = new Vector3(111.1f, -5f, 4.5f);
        }
    }
}