using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public playNote drum;
    public GameObject water;
    public GameObject drums;
    public GameObject explosion;
    public GameObject lillyPads;
    public GameObject littleTree;
    public GameObject bigTree;
    public GameObject trees;
    public GameObject canyon;
    public Material grass;
    public GameObject standStill2;
    public AudioSource backgroundMusic;

    public List<GameObject> rocks;

    void Update()
    {
        if (drum.score >= 20)
        {
            if(drum.score <= 30)
            {
                print("change water");
                water.transform.position = new Vector3(water.transform.position.x, drum.score/3, water.transform.position.z);
            }
            drums.transform.position = new Vector3(drums.transform.position.x, water.transform.position.y + 0.5f, drums.transform.position.z);

            if(drum.score == 35 && rocks.Count > 12)
            {
                for(int i = 0; i < 6; i++)
                {
                    int index = Random.Range(0,rocks.Count - 1);
                    Instantiate(explosion, rocks[index].transform.position, rocks[index].transform.rotation);
                    Destroy(rocks[index]);
                    rocks.Remove(rocks[index]);
                }
            }
            else if(drum.score == 45 && rocks.Count > 6)
            {
                for(int i = 0; i < 6; i++)
                {
                    int index = Random.Range(0,rocks.Count - 1);
                    Instantiate(explosion, rocks[index].transform.position, rocks[index].transform.rotation);
                    Destroy(rocks[index]);
                    rocks.Remove(rocks[index]);
                }
            }
            else if(drum.score == 55 && rocks.Count > 0)
            {
                for(int i = 0; i < 6; i++)
                {
                    int index = Random.Range(0,rocks.Count - 1);
                    Instantiate(explosion, rocks[index].transform.position, rocks[index].transform.rotation);
                    Destroy(rocks[index]);
                    rocks.Remove(rocks[index]);
                }
                backgroundMusic.Play();
                lillyPads.gameObject.SetActive(true);
                littleTree.gameObject.SetActive(false);
                bigTree.gameObject.SetActive(true);
                standStill2.gameObject.SetActive(true);
                trees.gameObject.SetActive(true);
                canyon.GetComponent<MeshRenderer>().material = grass;
            }
        }

        
    }
}
