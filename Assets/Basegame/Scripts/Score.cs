using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<GameManager>().gameended)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        
    }
}
