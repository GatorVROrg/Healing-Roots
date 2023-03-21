    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.XR.Interaction.Toolkit;

public class StandStillManager : MonoBehaviour
{
    public GameObject standStill;
    public GameObject Drums;
    public GameObject player;
    public bool taskCompleted = false;
    public AudioSource backgroundMusic;
    public AudioSource GameMusic;

    public playNote drums;
    public Conductor conductor;

    void Update()
    {
        if (taskCompleted == false)
        {
            if (Vector3.Distance(player.transform.position, standStill.transform.position) <= 2.5)
            {
                //player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
                //player.GetComponent<ActionBasedContinuousTurnProvider>().enabled = false;
                player.transform.position = new Vector3(standStill.transform.position.x, player.transform.position.y, standStill.transform.position.z);
                player.transform.rotation = standStill.transform.rotation;
                player.transform.parent = drums.transform;
                standStill.GetComponent<MeshRenderer>().enabled = false;
                drums.enabled = true;
                conductor.enabled = true;
                GameMusic.enabled = true;
                backgroundMusic.Stop();
            }
            else
            {
                //player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
                //player.GetComponent<ActionBasedContinuousTurnProvider>().enabled = true;
                player.transform.SetParent(null);
            }
        }
    }
}