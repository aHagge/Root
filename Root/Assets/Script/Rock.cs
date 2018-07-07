using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    public SphereCollider collide;
    public int stonehealth;
    public ParticleSystem rockparticle;
    public Transform ScrollViewGameObject;
    public GameObject stonetext;
    public static int stone;
    public GameObject stonechild;
    public static int randomstone;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hitbox")
        {
            randomstone = Random.Range(5, 10);
            stonehealth -= 1;
            GameObject UIstonetext = Instantiate(stonetext, ScrollViewGameObject) as GameObject;
            stone += randomstone;
            if (stonehealth <= 0)
            {
                collide.enabled = false;
                rockparticle.Play();
                StartCoroutine(Deletes());
                stonechild.SetActive(false);

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
        collide = gameObject.GetComponent(typeof(SphereCollider)) as SphereCollider;
        if (ScrollViewGameObject == null)
        {
            ScrollViewGameObject = GameObject.Find("Scroll View").transform;
        }
    }
}
