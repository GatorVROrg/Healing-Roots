using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public StandStillManager st;
    float[] noteTimings = {
        0.14f, 1.04f, 1.91f, 3.21f, 4.64f, 6.14f, 7.48f, 8.88f, 10.23f, 11.56f, 12.97f, 14.31f, 15.61f, 17.05f, 18.41f, 19.71f,
        21.16f, 22.14f, 23.69f, 25.09f,
        26.59f,
        27.91f, 29.32f, 30.67f, 32.00f, 33.49f, 34.79f,
        36.79f, 37.56f, 38.98f, 40.38f, 41.71f, 43.06f, 44.54f, 48.71f, 50.01f, 50.43f, 51.28f, 51.76f, 52.79f, 54.11f, 55.49f, 56.73f, 58.16f, 59.51f, 60.93f,
        61.89f, 61.96f, 62.33f, 62.68f, 62.93f, 63.63f,
        65.03f, 66.49f, 67.78f, 69.12f, 70.55f, 72.03f, 73.24f, 74.51f, 75.93f, 81.57f, 82.78f,
        84.13f, 85.68f, 87.14f, 87.43f, 87.74f, 88.15f, 88.43f, 88.83f,
        89.13f, 89.43f, 89.50f, 89.50f, 89.50f, 89.86f, 90.21f, 90.56f, 90.90f,  91.05f, 91.25f,
        92.57f, 93.84f, 95.24f, 96.66f, 98.05f, 99.37f, 100.7f, 100.10f, 100.39f, 100.79f, 101.09f, 101.09f, 101.43f, 101.71f, 102.01f, 103.49f, 104.78f, 106.05f, 107.40f, 108.82f, 110.19f, 111.48f, 112.97f, 114.34f,
        115.71f, 117.05f, 118.48f, 119.91f,
    };
    int[] drumPattern =   {
        1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0, 3,
        1, 3, 1, 3,
        0,
        1,3,1,3,1,3,
        0, 1, 2, 3, 0, 1, 2, 3, 0, 2, 0, 1, 3, 0, 1, 2, 3,
        1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0,
        1, 3, 1, 3,
        1, 2,
        0, 1, 2, 3, 0, 1, 2, 3, 0, 2, 0, 1, 3, 0, 1, 2, 3,
        1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0, 3, 1,
        1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0, 3, 1, 2, 0, 3,
        1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3,
        0, 1, 2, 3, 0, 1, 2, 3, 0, 2, 0, 1, 3, 0, 1, 2, 3,
    };

    float time = 0;
    int currentNote = 0;

    public Transform[] noteStartPos;
    public Transform[] noteEndPos;


    public GameObject[] note;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (currentNote < noteTimings.Length)
        {
            if(noteTimings[currentNote] - 1 < time)
            {
                GameObject newNote = Instantiate(note[drumPattern[currentNote]]);
                newNote.GetComponent<Note>().start = noteStartPos[drumPattern[currentNote]].position;
                newNote.GetComponent<Note>().end = noteEndPos[drumPattern[currentNote]].position;
                currentNote++;
            }
        }
        else
        {
            st.taskCompleted = true;
        }

    }
}
