using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsRandom : MonoBehaviour
{

    public GameObject hazard;
    public Vector2 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float space;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(spawnValues.x-30,spawnValues.x), spawnValues.y);
                spawnValues.x += space;
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            if (hazardCount >= 5)
            {
                yield return new WaitForSeconds(9);
                Destroy(gameObject);
            }




        }




    }




}
