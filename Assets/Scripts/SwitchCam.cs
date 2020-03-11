using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    [SerializeField]
    Camera fieldCam;
    [SerializeField]
    Camera playerCam;
    [SerializeField]
    Camera frontCam;
    bool switchCam = true;
    bool front = false;

    void Start()
    {
        fieldCam.GetComponent<Camera>().enabled = false;
        playerCam.GetComponent<Camera>().enabled = true;
        frontCam.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("y")) {
            switchCam = !switchCam;
            front = false;
        } else if (Input.GetKeyDown("f")) {
            front = !front;
        }
        fieldCam.GetComponent<Camera>().enabled = !switchCam;
        playerCam.GetComponent<Camera>().enabled = switchCam;
        frontCam.GetComponent<Camera>().enabled = front;
    }
}
