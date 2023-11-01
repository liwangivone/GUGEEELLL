using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;

    public GameObject[] UI;

    public void EnableSpawner()
    {
        GameObject.Find("PlayBtn").SetActive(false);

        foreach (GameObject g in UI)
            g.SetActive(true);

        StartCoroutine(StartSpawning());
    }

    public IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(3);

        Instantiate(enemies[Random.Range(0, 2)], spawnPoints[Random.Range(0, 8)].position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
}
