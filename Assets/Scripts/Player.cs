using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour  // It offers some life cycle functions that are easier for you to develop your app and game.
{
  // ECS - 
  // Public Methods/Variables
  /*
   * Can be excessed within engine and by other classes. 
   * Can be changed during runtime
  */

  public float xIncrement; // How far it can move in x in one move
  public float xLimit;
  public float x_Limit;
  public float playerSpeed; // At which speed player move in Y
  public int playerHealth;
  public GameObject playerEffect;
  public GameObject popSound;


  // Private Methods/Variables
  /*
   * Limited to this class and can not be excessed within engine
   * Can be changed during runtime
  */

  private Vector2 targetPos;

  private bool isMoving;




  // Awake is called before the Start function runs
  void Awake()
  {

  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (playerHealth <= 0)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    isMoving = false;


    // MoveTowards(startpos, targetPost, speed)
    // deltaTime = time spend between lastframe and the current frame 


    Debug.Log(transform.position.x);
    if (Input.GetKeyDown(KeyCode.LeftArrow) && (transform.position.x > x_Limit) && !isMoving)
    {
      /*
      *  The new operator is used to create an object or instantiate an object
      */
      targetPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
      // Instantiate(popSound, transform.position, Quaternion.identity);
      // Instantiate(playerEffect, transform.position, Quaternion.identity);
      isMoving = true;

    }
    else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < xLimit && !isMoving)
    {
      targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
      // Instantiate(popSound, transform.position, Quaternion.identity);
      // Instantiate(playerEffect, transform.position, Quaternion.identity);
      isMoving = true;
    }

    transform.position = Vector2.MoveTowards(
                  transform.position, targetPos,
                  playerSpeed * Time.deltaTime); // 60 - 16ms
    // transform.position = targetPos;

  }
}
