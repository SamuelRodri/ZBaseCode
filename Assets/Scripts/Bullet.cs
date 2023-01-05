using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject player;
    private GameController gameController;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").gameObject;
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            gameController.AddPoints();
            Destroy(collision.gameObject);
        }
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) > 30)
        {
            Destroy(this.gameObject);
        }
    }
}