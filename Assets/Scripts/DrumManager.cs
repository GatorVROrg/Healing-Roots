using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumManager : MonoBehaviour
{
    public GameObject drumLight1;
    public GameObject drumLight2;
    public GameObject drumLight3;
    public GameObject drumLight4;

    public int drum;
    public int numOfHits;   
    public StandStillManager standStill;

    void Awake() 
    {
        drum = Random.Range(0,4);    
    }        
    void Update() 
    {   
        if (numOfHits <= 20)
        {
            if(drum == 0)
            {
                drumLight1.SetActive(true);
            }
            else if (drum == 1)
            {
                drumLight2.SetActive(true);
            }
            else if (drum == 2)
            {
                drumLight3.SetActive(true);
            }
            else if (drum == 3)
            {
                drumLight4.SetActive(true);
            }
        }
        else
        {
            standStill.taskCompleted = true;
        }
    }
}
