using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

    public int LevelToLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Application.LoadLevel(LevelToLoad);
        }
    }
}
