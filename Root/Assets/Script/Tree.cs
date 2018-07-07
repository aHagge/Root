using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public CapsuleCollider collide;
    public int treehealth;
    public ParticleSystem leafs;
    public Transform ScrollViewGameObject;
    public GameObject woodtext;
    public static int wood;
    public GameObject treechild;
    public static int randomwood;
    public static int treeplants;
    public static int randomplant;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hitbox")
        {
            randomwood = Random.Range(5, 10);
            wood += randomwood;
            treehealth -= 1;
            GameObject UIwoodtext = Instantiate(woodtext, ScrollViewGameObject) as GameObject;
            if (treehealth <= 0)
            {
                randomplant = Random.Range(1, 3);
                collide.enabled = false;
                leafs.Play();
                StartCoroutine(Deletes());
                treechild.SetActive(false);
                treeplants += randomplant;
            }
        }
    }
    IEnumerator Deletes()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
    public void Start()
    {
        collide = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        if (ScrollViewGameObject == null)
        {
            ScrollViewGameObject = GameObject.Find("Scroll View").transform;
        }
    }
}
