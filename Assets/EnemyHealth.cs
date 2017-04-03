using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System;

public class EnemyHealth : MonoBehaviour
{

    public float enemyHealth = 100f;
    public Text healthText;
    public Text gameOver;
    public bool resetGame = false;
    float timeLeft = 5.0f;
    

    public void Start()
    {
        SetHealthText();
    }

    void Update ()
    {
        if (enemyHealth <= 0)
        {
            
            gameOver.text = "YOU WON!";
            timeLeft -= Time.deltaTime;
            RestartGame();
            if (timeLeft <= 0)
            {
                
            }
        }
       
    }


    public void RemoveHealth(float amount)
    {

        enemyHealth -= amount;
        if (enemyHealth <= 0)
        {
            Update();
            Destroy(gameObject);
        }

        SetHealthText();
    }

    void SetHealthText()
    {
        healthText.text = "Enemy health: " + enemyHealth.ToString();
    }


    void RestartGame()
    {
       
        Application.LoadLevel(0);

    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(5.0f);
        Application.LoadLevel(Application.loadedLevel);
    }

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(5.0f);
        RestartGame();
       
    }

}
