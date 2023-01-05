using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public GameObject gameOverPanel;

    public void setPoints(int points)
    {
        pointsText.text = "Points: " + points;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}