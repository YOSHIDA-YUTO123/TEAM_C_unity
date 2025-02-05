using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUPItem : MonoBehaviour
{

    public float SpeedUPAdd = 0.02f;
    public float SpeedLimit = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerControl>().MovePow += SpeedUPAdd;
            if(other.GetComponent<PlayerControl>().MovePow >= SpeedLimit)
            {
                other.GetComponent<PlayerControl>().MovePow = SpeedLimit;
            }
            Destroy(gameObject);
        }
    }
}
