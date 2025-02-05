using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagerEX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
        {// ƒQ[ƒ€ƒV[ƒ“‚ğ“Ç‚İ‚Ş
            SceneManager.LoadScene("GameScene");
        }
    }
}
