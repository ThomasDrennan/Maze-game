using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {
    private float rotateSpeed = 10f;
    GameManagerScript GMS;
    // Use this for initialization

    void Awake()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.cur_coins++;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.left * rotateSpeed);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            GMS.cur_coins--;
            GMS.UpdateUI();
        }
    }
}
