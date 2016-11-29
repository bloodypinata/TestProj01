using UnityEngine;
using System.Collections;

public class openSayDialog : MonoBehaviour {

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
            if (Input.GetKeyDown("space") || Input.GetKeyDown("e"))
            {
                //call out to fungus SayDialog in the scene
                Fungus.Flowchart.BroadcastFungusMessage("talkToDad");
            }
        }
    }
	

}
