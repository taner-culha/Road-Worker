using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllers;
    private float leftBound = -20;
    void Start()
    {
        playerControllers = GameObject.Find("RoadWorker_Black").GetComponent<PlayerController>();
    }
    void Update()
    {
        if (playerControllers.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x< leftBound && gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }
    }
}
