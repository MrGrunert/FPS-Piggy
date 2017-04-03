using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float playerHealth = 100f;
    public Text healthText;

    void Start()
    {
        SetHealthText();
    }

    public void RemoveHealth(float amount)
    {
        playerHealth -= amount;
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
        SetHealthText();
    }

    void SetHealthText()
    {
        healthText.text = "Player health: " + playerHealth.ToString();
    }
}
