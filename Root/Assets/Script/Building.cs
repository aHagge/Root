using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{

    public Image noselect, wallselect, floorselect, doorselect, stairsselect;
    public KeyCode buildmenu;
    public bool buildingmode;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (Input.GetKeyDown(buildmenu))
        {
            buildingmode = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyUp(buildmenu))
        {
            buildingmode = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            doorselect.GetComponent<Image>().enabled = false;
            wallselect.GetComponent<Image>().enabled = false;
            stairsselect.GetComponent<Image>().enabled = false;
            floorselect.GetComponent<Image>().enabled = false;
            noselect.GetComponent<Image>().enabled = false;
        }







        //building on
        if (buildingmode == true)
        {
            if (mousePosition.x <= (Screen.width / 2) && mousePosition.y <= (Screen.height / 2))
            {
                doorselect.GetComponent<Image>().enabled = true;
                wallselect.GetComponent<Image>().enabled = false;
                stairsselect.GetComponent<Image>().enabled = false;
                floorselect.GetComponent<Image>().enabled = false;
                noselect.GetComponent<Image>().enabled = false;
            }
            if (mousePosition.x >= (Screen.width / 2) && mousePosition.y <= (Screen.height / 2))
            {
                doorselect.GetComponent<Image>().enabled = false;
                wallselect.GetComponent<Image>().enabled = false;
                stairsselect.GetComponent<Image>().enabled = true;
                floorselect.GetComponent<Image>().enabled = false;
                noselect.GetComponent<Image>().enabled = false;
            }
            if (mousePosition.x >= (Screen.width / 2) && mousePosition.y >= (Screen.height / 2))
            {
                doorselect.GetComponent<Image>().enabled = false;
                wallselect.GetComponent<Image>().enabled = false;
                stairsselect.GetComponent<Image>().enabled = false;
                floorselect.GetComponent<Image>().enabled = true;
                noselect.GetComponent<Image>().enabled = false;
            }
            if (mousePosition.x <= (Screen.width / 2) && mousePosition.y >= (Screen.height / 2))
            {
                doorselect.GetComponent<Image>().enabled = false;
                wallselect.GetComponent<Image>().enabled = true;
                stairsselect.GetComponent<Image>().enabled = false;
                floorselect.GetComponent<Image>().enabled = false;
                noselect.GetComponent<Image>().enabled = false;
            }
        }
    }
}
