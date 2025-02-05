using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkUPItem : MonoBehaviour
{

    public int AtkUPAdd = 5;
    public int AtkLimit = 30;
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
            other.GetComponent<PlayerControl>().ATK += AtkUPAdd;
            if (other.GetComponent<PlayerControl>().MovePow >= AtkLimit)
            {
                other.GetComponent<PlayerControl>().MovePow = AtkLimit;
            }
            Destroy(gameObject);
        }
    }
}
