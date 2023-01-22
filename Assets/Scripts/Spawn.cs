using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Birdy birdScript;

    public GameObject Borular;

    public float time;

    private void Start() 
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(Borular, new Vector3(1.5f, Random.Range(0.1f, 0.9f), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
