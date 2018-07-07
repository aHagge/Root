using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodgrow : MonoBehaviour {
    public GameObject treeprefab;
    public Vector3 positions;
    private int randomtreetime;
	// Use this for initialization
	void Start () {
        randomtreetime = Random.Range(500, 600);
        positions = gameObject.transform.position;
        StartCoroutine(Grow());
    }

    IEnumerator Grow()
    {
        yield return new WaitForSeconds(randomtreetime);
        Destroy(gameObject);
        Instantiate(treeprefab, positions, Quaternion.identity);

    }
}
