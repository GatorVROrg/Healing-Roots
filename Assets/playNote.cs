using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class playNote : MonoBehaviour
{
    public int score = 0;
    GameObject note;

    public TMP_Text text;

    public GameObject playedNoted;

    public AudioSource Song;

    public void Start()
    {
        Song = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + score;
    }

    public void Drum1()
    {
        note = GameObject.FindGameObjectWithTag("Note1");
        if (note)
        {
            if (note.GetComponent<Note>().canHit)
            {
                score++;
                Instantiate(playedNoted, note.transform.position, Quaternion.identity);
                Destroy(note);
            }
        }
    }

    public void Drum2()
    {
        note = GameObject.FindGameObjectWithTag("Note2");
        if (note)
        {
            if (note.GetComponent<Note>().canHit)
            {
                score++;
                Instantiate(playedNoted, note.transform.position, Quaternion.identity);
                Destroy(note);
            }
        }
    }

    public void Drum3()
    {
        note = GameObject.FindGameObjectWithTag("Note3");
        if (note)
        {
            if (note.GetComponent<Note>().canHit)
            {
                score++;
                Instantiate(playedNoted, note.transform.position, Quaternion.identity);
                Destroy(note);
            }
        }
    }

    public void Drum4()
    {
        note = GameObject.FindGameObjectWithTag("Note4");
        if (note)
        {
            if (note.GetComponent<Note>().canHit)
            {
                score++;
                Instantiate(playedNoted, note.transform.position, Quaternion.identity);
                Destroy(note);
            }
        }
    }
}
