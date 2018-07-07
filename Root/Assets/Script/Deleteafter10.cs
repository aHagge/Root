using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleteafter10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Deletes());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Deletes()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
