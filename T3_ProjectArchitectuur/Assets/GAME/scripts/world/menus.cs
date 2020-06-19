using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject GameController;
    public Camera Playercam;
    public Camera mainmenucam;
    public Transform spawn;
    public bool enabled;
    // Start is called before the first frame update
    void Start()
    {

        GameController = GameObject.Find("GameController");
        Mainmenu = GameObject.Find("MainMenu");
        spawn = GameObject.Find("spawnlocation").transform;
        Playercam = GameObject.Find("Playercam").GetComponent<Camera>();
        mainmenucam = GameObject.Find("menucam").GetComponent<Camera>();
        Playercam.enabled = false;
        mainmenucam.enabled = true;
        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mainmenu.GetComponent<Canvas>().enabled == true)
        {
            GameController.GetComponent<pause>().gopause = true;
             enabled = true;

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Playercam.enabled = false;
            mainmenucam.enabled = true;
            Mainmenu.GetComponent<Canvas>().enabled = true;
            GameController.GetComponent<pause>().gopause = true;
            Cursor.visible = true;

        }
    }
    public void Play()
    {

        Mainmenu.GetComponent<Canvas>().enabled = false;
        GameController.GetComponent<pause>().gopause = false;
        Playercam.enabled = true;
        mainmenucam.enabled = false;
        enabled = false;
        Cursor.visible = false;
    }


}