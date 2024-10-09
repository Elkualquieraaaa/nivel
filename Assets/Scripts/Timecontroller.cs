using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timecontroller : MonoBehaviour
{
    public float currenttime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startimer(float time) 
    {
        currenttime = time;
        if (currenttime > 0)
        {
            currenttime -= Time.deltaTime;
            if (currenttime < 0)
            {
                currenttime = 0;
            }
        }
    }
}
