using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthmanagement : MonoBehaviour
{
    [SerializeField]float vida;

    public void recibirdaño(float daño)
    {
        vida -= daño;

        if (vida <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
