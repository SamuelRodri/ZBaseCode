using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthController : MonoBehaviour
{
    public Image health;

    public float actualHealth;
    public float maxHealth;

    private void Awake()
    {
        maxHealth = GameObject.Find("Player").GetComponent<PlayerController>().health;
        actualHealth = maxHealth;
    }

    private void Update()
    {
        health.fillAmount = actualHealth / maxHealth;
        actualHealth = GameObject.Find("Player").GetComponent<PlayerController>().health;
    }
}