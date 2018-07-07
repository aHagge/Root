using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public GameObject Player;

    public Vector3 spawnpoint2;

    public Transform spawnpoint;
    // Use this for initialization
    void Start () {
        spawnpoint2 = spawnpoint.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DEATH();
        }
    }
    public void DEATH()
    {
        Player.transform.position = spawnpoint2; 
    }
}
