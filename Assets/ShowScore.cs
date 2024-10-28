using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI final;
    public Transform player;

    void Update()
    {
        if (FindObjectOfType<GameManager>().gameended)
        {
            final.text = "Final Score: " + player.position.z.ToString("0");
            Invoke("finalscoreUItrig",0F);
        }
    }
    void finalscoreUItrig()
    {
        final.enabled = true;
    }
}
