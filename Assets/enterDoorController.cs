using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enterDoorController : MonoBehaviour {

    public int levelToLoad;

    void Start()
    {
    }
	

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
        
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(Input.GetKeyDown("space") || Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
