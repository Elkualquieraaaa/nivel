using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curamanagement : MonoBehaviour
{
    [SerializeField] float cura;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Healthmanagement>())
        {
            collision.GetComponent<Healthmanagement>().recibircura(cura);
            Destroy(gameObject);
        }
    }
}
