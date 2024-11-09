using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulatormanager : MonoBehaviour
{
                                                                                                 
    public static Simulatormanager instance;

    [SerializeField] Timecontroller Timecontroller;
    [SerializeField] Charactermovement character;

    public Scorecontroller scorecontroller;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        { 
            Destroy(gameObject); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (character.tocandoelsuelo == false)
        {
            Timecontroller.Startimer(5);
        }
    }
}
