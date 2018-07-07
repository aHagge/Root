using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehavior : MonoBehaviour {

    public GameObject Smallchickenprefab;
    public Transform Animalsempty;
	// Use this for initialization
	void Start () {
        StartCoroutine(Egghatch());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Egghatch()
    {
        yield return new WaitForSeconds(10);       
        Instantiate(Smallchickenprefab, transform.position, Quaternion.identity, Animalsempty);
        Destroy(gameObject);
    }
}
