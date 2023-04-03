using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        //❕ public string objectName;
        private void Start()
        {
            GameObject[] objetos = GameObject.FindObjectsOfType<GameObject>();
            for (int i = 0; i < objetos.Length; i++)
            {
                objetos[i].name = "Este es el GameObjecto numero: " + (i + 1);
                //❕objetos[i].name = objectName;
            }
        }
    }
}