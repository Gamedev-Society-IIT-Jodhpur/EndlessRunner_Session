using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
  public GameObject spawnPoint;

  private void Start()
  {
    Instantiate(spawnPoint, transform.position, Quaternion.identity);
  }
}
