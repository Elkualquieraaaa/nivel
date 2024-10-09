using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemscroe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int score;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Simulatormanager.instance.scorecontroller.Addscore(score);
        }
    }
}
