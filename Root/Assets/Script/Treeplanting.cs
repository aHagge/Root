using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treeplanting : MonoBehaviour {

    public GameObject treeplant;
    public Transform lvlgameobject;
    private Vector3 spawnvector;

    public bool plantableground;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnvector.x = gameObject.transform.position.x;
        spawnvector.y = (gameObject.transform.position.y - 1);
        spawnvector.z = gameObject.transform.position.z;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "plantable")
        {
            plantableground = true;
        }
        if(collision.gameObject.tag == "notplantable")
        {
            plantableground = false;
        }
    }
    public void Planttree()
    {
        if(plantableground == true)
        {
            Instantiate(treeplant, spawnvector , Quaternion.identity, lvlgameobject);
            Tree.treeplants -= 1;
        } else
        {
            Debug.Log("Not able to plant on this suface");
        }
    }
}
