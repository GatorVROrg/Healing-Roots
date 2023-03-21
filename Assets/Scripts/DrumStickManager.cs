using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumStickManager : MonoBehaviour
{
    public Transform place;
    public void PickUp()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
    public void PutDown()
    {
        gameObject.transform.position = place.position;
        gameObject.transform.rotation = place.rotation;
    }

}
