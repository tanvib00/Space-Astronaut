using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlatform : MonoBehaviour
{
    Player astro;
    MazeMgr boss;
    BlockMgr b_dude;
    private float speed = 0.5f;
    private Vector3 startPosition;
    private Vector3 origStart;
    public float max = 12.0f;
    private bool up = false;

    void Start()
    {
        astro = GameObject.FindObjectOfType<Player>();
        boss = GameObject.FindObjectOfType<MazeMgr>();
        b_dude = GameObject.FindObjectOfType<BlockMgr>();
        startPosition = transform.position;
        origStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if ((astro.transform.position.z < startPosition.z + 7.5f) && 
            (astro.transform.position.z > startPosition.z - 7.5f) &&
            (astro.transform.position.x < startPosition.x + 7.5f) &&
            (astro.transform.position.x > startPosition.x - 7.5f)) {
                GoUp();
            }
        else {
            if (transform.position.y > startPosition.y) {
                GoDown();
            }
        }*/
        if (!boss.stopMovement) {
            //Vector3 v = startPosition;
            //v.y += amp * Mathf.Sin (Time.time * speed); 
            //transform.position = v;
            if (Input.GetKeyDown("p")) {
                b_dude.PlaceBlock();
            }
        }
    }

    void GoUp() {
        Vector3 v = startPosition;
        /*if (v.y < startPosition.y + max) {
            Debug.Log("goin up");
            v.y += speed * Time.deltaTime;
            transform.position = v;
            up = true;
        } else {
            up = false;
        }*/
        if (transform.position.y >= origStart.y + max - 3.0f) {
            v.y = origStart.y + max;
        } else {
            v.y += max * Mathf.Sin (Time.time * speed); 
        }
        transform.position = v;
    }

    void GoDown() {
        up = false;
        Vector3 v = startPosition;
        if (transform.position.y <= origStart.y + 1.0f) {
            v.y = origStart.y;
        } else {
            v.y -= max * Mathf.Sin (Time.time * speed); 
        }
        transform.position = v;
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            ;
        }
    }
}