using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public GameObject[] enemyList;

  public float startTimeBWSpawn;
  public float decreaseTime;
  public float minTime = 0.05f;
  private float timeBWSpawn;

  // Update is called once per frame
  void Update()
  {
    if (timeBWSpawn <= 0)
    {
      int rand = Random.Range(0, enemyList.Length); // 0 1 2[) [1,2,3]
      Instantiate(enemyList[rand], transform.position, Quaternion.identity);
      timeBWSpawn = startTimeBWSpawn;
      if (startTimeBWSpawn > minTime)
      {
        startTimeBWSpawn -= decreaseTime;
      }
    }
    else
    {
      timeBWSpawn -= Time.deltaTime; // Devrease the time
    }

  }
}
