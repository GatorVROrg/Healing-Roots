using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucket : MonoBehaviour
{
    public Material color;
    public GameObject brushTip;
    public GameObject paint;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.Equals("PaintBrush"))
        {
            brushTip.GetComponent<MeshRenderer>().material = color;
            paint.GetComponent<MeshRenderer>().material = color;
        }
    }
}
