using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public bool gameended = false;
    public void EndGame()
    {

        if (!gameended) {
            gameended = true;
            Debug.Log("game over");
            score.enabled = false; 
            Invoke("Restart", 2F);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   }

