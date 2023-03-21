using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrushManager : MonoBehaviour
{
    public GameObject paint;
    public Transform tip;
    public Transform place;
    private bool painting = false;
    private Vector3 previousPosition;

    void Start()
    {
        previousPosition = tip.position;
    }

    void Update()
    {
        if(painting)
        {
            Vector3 currentPosition = tip.position;

            if (currentPosition != previousPosition)
            {
                GameObject paintBlotch = Instantiate(paint, tip.position, tip.rotation);
            }

            previousPosition = currentPosition;
        }
    }

    public void StartPainting() 
    {
        painting = true;
    }

    public void StopPainting()
    {
        painting = false;
    }

    public void PickUp()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
