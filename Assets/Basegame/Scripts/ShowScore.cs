using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net.Sockets;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI final;
    public TextMeshProUGUI score;
    public Transform player;
    public Animator animator;


    void Update()
    {
        if (FindObjectOfType<GameManager>().gameended)
        {
            final.text = $"Score: {score.text}";
            finalscoreUItrig();
        }
        if (final.enabled && animator != null)
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }
    void finalscoreUItrig()
    {
        final.enabled = true;

    }
}
