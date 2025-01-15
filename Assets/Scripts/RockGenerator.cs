using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenRock", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(rockPrefab, new Vector3(1000.0f * Random.value, 6.0f, 0.0f), Quaternion.identity);
        Instantiate(rockPrefab, new Vector3(-1000.0f * Random.value, 6.0f, 0.0f), Quaternion.identity);
    }
}