using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagemanagement : MonoBehaviour
{
    [SerializeField] float daño;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Healthmanagement>())
        {
            collision.gameObject.GetComponent<Healthmanagement>().recibirdaño(daño);
        }
    }
}
