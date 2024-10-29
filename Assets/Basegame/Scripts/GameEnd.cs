//using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{

    public RawImage gameover;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameended)
        {
            gameoverUItrig();
        }
        if (gameover.enabled && animator != null)
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }


    void gameoverUItrig()
    {
            gameover.enabled = true;
    }
}
