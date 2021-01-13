using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int damage; // How much damage to give the player
  public float speed;

  public GameObject enemyEffect;
  public GameObject enemyDeathSound;

  private void Update()
  {
    // To move the enemy towards the player
    transform.Translate(Vector2.down * speed * Time.deltaTime); // left = -x
  }


  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      other.GetComponent<Player>().playerHealth -= damage; // decreasing the health of player
      Instantiate(enemyEffect, transform.position, Quaternion.identity);
      Instantiate(enemyDeathSound, transform.position, Quaternion.identity);

      Destroy(gameObject); // will destry this game object
    }
  }
}
