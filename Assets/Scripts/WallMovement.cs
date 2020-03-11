using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    Player astro;
    MazeMgr boss;
    private float speed;
    private Vector3 startPosition;
    public bool horizontal;
    public float amp = 14; // arbitrary max movement, set for each one manually (terrible, i know)

    void Start()
    {
        astro = GameObject.FindObjectOfType<Player>();
        boss = GameObject.FindObjectOfType<MazeMgr>();
        speed = Random.Range(2.0f, 9.0f);
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!boss.stopMovement) {
            Vector3 v = startPosition;
            if (horizontal) {
                // this method for oscillation found on a forum
                v.z += amp * Mathf.Sin (Time.time * speed); 
                transform.position = v;
            } else {
                v.x += amp * Mathf.Sin (Time.time * speed);
                transform.position = v;
            }
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            astro.gameover = true;
            boss.gameOver = true;
        }
    }
}
