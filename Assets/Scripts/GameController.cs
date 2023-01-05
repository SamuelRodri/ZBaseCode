using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int points = 0;

    public delegate void ZombieDie();
    public event ZombieDie OnZombieDie;

    public UIController ui;
    public bool gameOver = false;

    public void AddPoints()
    {
        points += 100;
        ui.setPoints(points);
    }

    private void Update()
    {
        if(GameObject.Find("Player").GetComponent<PlayerController>().health <= 0)
        {
            GameOver();
            gameOver = true;
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameObject.Find("UIController").GetComponent<UIController>().GameOver();
    }
}