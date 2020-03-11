using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    Player astro;
    private Vector3 startPosition;
    private float speed = 3.0f;
    private float amp = 1.0f;

    void Start()
    {
        astro = GameObject.FindObjectOfType<Player>();
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
            GameObject.FindObjectOfType<BlockMgr>().GetOre();
            Destroy(gameObject);
        }
    }
}
