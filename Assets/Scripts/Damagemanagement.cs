using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagemanagement : MonoBehaviour
{
    [SerializeField] float da�o;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Healthmanagement>())
        {
            collision.gameObject.GetComponent<Healthmanagement>().recibirda�o(da�o);
        }
    }
}
