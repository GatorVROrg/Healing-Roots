using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drum : MonoBehaviour
{
    public playNote drum;

    public AudioSource sound;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.Equals("DrumStick"))
        {
            sound.Play();
            if(gameObject.name == "Surface1")
            {
                drum.Drum1();
            }
            if (gameObject.name == "Surface2")
            {
                drum.Drum2();
            }
            if (gameObject.name == "Surface3")
            {
                drum.Drum3();
            }
            if (gameObject.name == "Surface4")
            {
                drum.Drum4();
            }
        }
    }
}