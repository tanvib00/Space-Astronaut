using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starship : MonoBehaviour
{
    Player astro;
    MazeMgr boss;
    private Vector3 startPosition;
    private float speed = 2.0f;
    private float amp = 2.0f;

    void Start()
    {
        astro = GameObject.FindObjectOfType<Player>();
        boss = GameObject.FindObjectOfType<MazeMgr>();
        speed = Random.Range(2.0f, 9.0f);
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 v = startPosition;
        v.y += amp * Mathf.Sin (Time.time * speed);
        transform.position = v;
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            boss.gameWon = true;
            Destroy(gameObject);
        }
    }
}
