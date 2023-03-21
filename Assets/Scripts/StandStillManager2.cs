using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StandStillManager2 : MonoBehaviour
{
    public GameObject standStill;
    public GameObject player;
    public GameObject paintMenu;    
    public GameObject paintBrush;

    void Update()
    {
        if (Vector3.Distance(player.transform.position, standStill.transform.position) <= 2.5)
        {
            standStill.GetComponent<MeshRenderer>().enabled = false;
            paintMenu.gameObject.SetActive(true);
            paintBrush.gameObject.SetActive(true);
        }
    }
}
