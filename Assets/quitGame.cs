using UnityEngine;
using System.Collections;

public class quitGame : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
