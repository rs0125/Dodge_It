using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement move;
    public Rigidbody rb;
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            move.enabled = false;
            audio.Play();
            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
