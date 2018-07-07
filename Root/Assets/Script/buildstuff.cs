using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildstuff : MonoBehaviour {

    public List<buildobjects> objects = new List<buildobjects>();
    public buildobjects currentobject;
    private Vector3 currentpos;
    public Transform currentpreview;
    public Transform cam;
    public RaycastHit hit;
    public LayerMask layer;
    public float offset = 1.0f;
    public float gridSize = 1.0f;

    public bool isbuilding;

    public void ChangeCurrentBuilding ()

    {
        GameObject curprev = Instantiate(currentobject.preview,currentpos , Quaternion.identity) as GameObject;
        currentpreview = curprev.transform;

    }

    public void startpreview()
    {
        if(Physics.Raycast(cam.position, cam.forward, out hit, 10, layer))
        {
            if(hit.transform != this.transform)
            {
                showpreview(hit);
            }
        }
    }

    void Update()
    {
        if(isbuilding)
        {
            startpreview();
        }
    }

    void Start () {
        currentobject = objects[0];
        ChangeCurrentBuilding();
	}
	
    public void showpreview (RaycastHit hit2)
    {
        currentpos = hit2.point;
        currentpos -= Vector3.one * offset;
        currentpos /= gridSize;
        currentpos = new Vector3(Mathf.Round(currentpos.x), Mathf.Round(currentpos.y), Mathf.Round(currentpos.z));
        currentpos *= gridSize;
        currentpos += Vector3.one * offset;
        currentpreview.position = currentpos;
        currentpreview.position = currentpos;
    }

    [System.Serializable]
    public class buildobjects
    {
        public string name;
        public GameObject preview;
        public int wood;
}

}
