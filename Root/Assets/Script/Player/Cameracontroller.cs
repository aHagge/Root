using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;
    public Vector3 rotation;
    public int under, top;
    public static float vertical;
    private bool wrong;
    void Start()
    {

    }

    private void FixedUpdate()
    {
        rotation = transform.rotation.eulerAngles;
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        vertical = Input.GetAxis("Mouse Y");
        target.transform.RotateAround(target.transform.position, target.transform.up, horizontal);
        transform.RotateAround(target.transform.position, target.transform.right, vertical);

        
    }
}