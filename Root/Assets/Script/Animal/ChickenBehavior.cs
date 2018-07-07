using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBehavior : MonoBehaviour
{
    public Transform Eggsempty;
    public GameObject eggprefab;
    public Transform spawnegghere;

    public Animator Anim;
    public bool grounded;

    public float movementspeed = 3f;
    public float rotspeed = 100f;

    private bool iswandering = false;
    private bool isrotleft = false;
    private bool isrotright = false;
    private bool iswalking = false;

    private int randomeggtime;

    private void Start()
    {
        StartCoroutine(eggspawner());
        Eggsempty = GameObject.Find("Alleggs").transform;
    }
    IEnumerator eggspawner()
    {
        randomeggtime = Random.Range(100, 500);
        yield return new WaitForSeconds(randomeggtime);
        Instantiate(eggprefab, spawnegghere.position, Quaternion.identity, Eggsempty);
        StartCoroutine(eggspawner());
    }
    private void Update()
    {
        if(iswalking)
        {
            Anim.SetBool("iswalking", true);
        } else
        {
            Anim.SetBool("iswalking", false);
        }             
        if (iswandering == false)
        {
            StartCoroutine(Wander());
        }
        if(isrotright == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotspeed);
        }
        if (isrotleft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotspeed);
        }
        if(iswalking == true)
        {
            transform.position += transform.forward * movementspeed * Time.deltaTime;
        }

        if(grounded == false)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotspeed);
        }
    }
    IEnumerator Wander()
    {
        int rottime = Random.Range(1, 3);
        int rotwait = Random.Range(1, 4);
        int rotatelorR = Random.Range(0, 3);
        int walkwait = Random.Range(1, 4);
        int walktime = Random.Range(1, 5);


        iswandering = true;

        yield return new WaitForSeconds(walkwait);
        iswalking = true;
        yield return new WaitForSeconds(walktime);
        iswalking = false;
        yield return new WaitForSeconds(rotwait);
        if(rotatelorR == 1)
        {
            isrotright = true;
            yield return new WaitForSeconds(rottime);
            isrotright = false;
        }
        if (rotatelorR == 2)
        {
            isrotleft = true;
            yield return new WaitForSeconds(rottime);
            isrotleft = false;
        }
        iswandering = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "plantable")
        {
            grounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "plantable")
        {
            grounded = false;
        }
    }

    
}
