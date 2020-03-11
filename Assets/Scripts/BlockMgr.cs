using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockMgr : MonoBehaviour
{
    public int nblocks;
    private int bsize = 0; // yes they are squares
    public Text blocktext;
    MazeMgr m;
    private bool lost;
    public GameObject bridgePrefab;
    private Vector3 putLocation;

    void Start()
    {
        m = GameObject.FindObjectOfType<MazeMgr>();
        blocktext = GetComponent<Text>();
        nblocks = 0;
        lost = false;
        putLocation = new Vector3(-55, -3, 3);
    }

    void Update() {
        if (!m.gameOver && !lost) {
            blocktext.text = "Blocks Owned : " + nblocks;
        }
        else if (m.gameOver) {
            lost = true;
        }
        if (lost) {
            blocktext.text = "";
        }
    }

    public void GetBlock() {
        nblocks++;
    }

    public void GetOre() {
        nblocks += 3;
    }

    public void GetStainlessSteel() {
        nblocks += 5;
    }

    public void PlaceBlock() {
        if (nblocks/4 >= 0) {
            nblocks-= 4;
            // instantiate block prefab
            GameObject.Instantiate(bridgePrefab, putLocation, Quaternion.identity);
            putLocation = new Vector3(putLocation.x - 5.0f, -3.0f, putLocation.z) ;
        }
    }
}
