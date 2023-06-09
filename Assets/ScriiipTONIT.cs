using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject objects;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(time);
        var newObj = (GameObject)Instantiate(objects, SpawnPos.position, Quaternion.identity);
        Destroy(newObj, time + 20);

        Repeat();
    }
}
