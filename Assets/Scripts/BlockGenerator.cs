using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject orePrefab;
    public GameObject steelPrefab;
    void Start()
    {
        for (int i = 0; i < 60; i++) {
            Vector3 h = new Vector3(Random.Range(-50, 50), 2.2f, Random.Range(-50, 50));
            GameObject.Instantiate(blockPrefab, h, Quaternion.identity);
        }

        for (int i = 0; i < 20; i++) {
            Vector3 h = new Vector3(Random.Range(-50, 50), 3.0f, Random.Range(-50, 50));
            GameObject.Instantiate(orePrefab, h, Quaternion.identity);
        }

        for (int i = 0; i < 12; i++) {
            Vector3 h = new Vector3(Random.Range(-50, 50), 3.0f, Random.Range(-50, 50));
            GameObject.Instantiate(steelPrefab, h, Quaternion.identity);
        }
    }
}
