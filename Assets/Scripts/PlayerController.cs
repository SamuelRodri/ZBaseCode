using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    public int facing = -1;
    public GameObject cylinder;

    public GameObject bullet;

    public float health = 100;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameController").GetComponent<GameController>().gameOver)
        {
            return;
        }
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical") * facing;
        Vector3 movement = new Vector3(xMove, 0, zMove);

        transform.Translate(movement * speed * Time.deltaTime);

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        var bullet2 = Instantiate(bullet, cylinder.transform.position, bullet.transform.rotation);
        bullet2.GetComponent<Rigidbody>().AddForce(cylinder.transform.forward * 1000);
    }

    public void Hit()
    {
        Debug.Log("Pierdo Vida");
        health -= 10;
    }
}