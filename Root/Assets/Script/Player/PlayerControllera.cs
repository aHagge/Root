using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllera : MonoBehaviour {

    public Rigidbody RB;

    public KeyCode Turnright;
    public KeyCode Turnleft;
    public KeyCode Moveforward;
    public KeyCode Movebackwards;
    public KeyCode Pause;

    public float movespeed;
    public Vector3 userDirection = Vector3.forward;
    public Vector3 userDirection1 = Vector3.back;
    public Vector3 userdirection2 = Vector3.right;
    public Vector3 userdirection3 = Vector3.left;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKeyDown(Pause))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
        if(Input.GetKey(Turnright))
        {
            transform.Translate(userdirection3 * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(Turnleft))
        {
            transform.Translate(userdirection2 * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(Moveforward))
        {
            transform.Translate(userDirection * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(Movebackwards))
        {
            transform.Translate(userDirection1 * movespeed * Time.deltaTime);
        }
        
    }
}
