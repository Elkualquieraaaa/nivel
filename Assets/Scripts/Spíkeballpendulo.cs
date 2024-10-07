using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spíkeballpendulo : MonoBehaviour
{
    public List<Transform> objetivos = new List<Transform>();
    [SerializeField] float velocity;
    int objetivoactual = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in objetivos)
        {
            t.SetParent(null);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, objetivos[objetivoactual].rotation, velocity * Time.deltaTime);


        if (transform.rotation == objetivos[objetivoactual].rotation)
        {
            objetivoactual++;
            if (objetivoactual > objetivos.Count - 1)
            {
                objetivoactual = 0;
            }
        }
    }
}