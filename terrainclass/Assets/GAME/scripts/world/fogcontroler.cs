using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogcontroler : MonoBehaviour
{
    public GameObject GameController;

    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "inside" && GameController.GetComponent<menus>().enabled == false)
        {
           // RenderSettings.fog = false;
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "inside")
        {

            //RenderSettings.fog = true;
        }
    }
}
