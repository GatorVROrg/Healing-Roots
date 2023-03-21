using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAnimation : MonoBehaviour
{
    Vector3 start_pos;
    Vector3 end_pos;

    private void Awake()
    {
        start_pos = transform.position;
        end_pos = transform.position + (Vector3.up * 2.5f) + (Vector3.left * 2.5f);
    }

    public IEnumerator play(float time)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            transform.position = Vector3.Lerp(end_pos, start_pos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(stop());
    }

    public IEnumerator stop()
    {
        yield return new WaitForSecondsRealtime(1f);
        gameObject.SetActive(false);
    }
}
