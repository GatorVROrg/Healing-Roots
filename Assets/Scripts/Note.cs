using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;

    float elaspedTime = 0;
    float lerpTime = 1;

    public bool canHit = false;
    bool fistRun = true;
    public Vector3 ogScale;



    // Update is called once per frame
    void Update()
    {
        if (transform.position != end)
        {
            transform.position = Vector3.Lerp(start, end, elaspedTime / lerpTime);
            if (elaspedTime / lerpTime > 0.75)
            {
                canHit = true;
            }
            elaspedTime += Time.deltaTime;
        }
        else
        {
            StartCoroutine(kill());
        }

        if (canHit && fistRun)
        {
            fistRun = false;
            ogScale = transform.localScale;
            transform.localScale *= 2;
        }
    }

    IEnumerator kill()
    {
        yield return new WaitForEndOfFrame();
        transform.localScale = ogScale;
        canHit = false;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
