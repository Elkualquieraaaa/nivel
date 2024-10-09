using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthmanagement : MonoBehaviour
{
    [SerializeField]float vida;
    [SerializeField]float vidamax;

    public void recibirda�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0) 
        {
            Destroy(gameObject);
        }
    }
    public void recibircura(float cura)
    {
        vida += cura;

        if (vida > vidamax)
        {
            vida = vidamax;
        }
    }
}
