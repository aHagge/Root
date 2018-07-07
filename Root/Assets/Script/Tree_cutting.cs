using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_cutting : MonoBehaviour {


    public GameObject hitbox;
    private bool running;
    // Use this for initialization
    void Start () {
        hitbox.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(running == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Swing());
            }
        }
    }
    IEnumerator Swing()
    {
        running = true;
        hitbox.SetActive(true);
        
        yield return new WaitForSeconds(1);
        hitbox.SetActive(false);
        running = false;
    }
}
