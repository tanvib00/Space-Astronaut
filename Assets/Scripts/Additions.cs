using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Additions : MonoBehaviour
{
    Player astro;
    private Vector3 mv = Vector3.zero;
    public float speed = 600.0f;
    void Start()
    {
        astro = GameObject.FindObjectOfType<Player>();
        //controller = GetComponent <CharacterController>();
		//anim = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown ("space")) {
			mv = transform.up * Input.GetAxis("Vertical") * speed;
			//controller.AddForce(Vector3.up *15.0f);
            //GetComponent<ConstantForce>().force = new Vector3(0, 4.0f, 0);
	    	transform.Translate(Vector3.up * 15 * Time.deltaTime, Space.World);
        } else {
            //astro.gameover = false;
        }

		//astro.controller.Move(mv * Time.deltaTime);
    	//moveDirection.y -= gravity * Time.deltaTime;
    }
}
