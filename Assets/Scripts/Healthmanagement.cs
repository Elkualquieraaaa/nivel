using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthmanagement : MonoBehaviour
{
    [SerializeField]float vida;

    public void recibirda�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
