using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    RaycastHit hit;
    public GameObject activatablething;
    public GameObject inv;
    public GameObject GameController;
   

    // Update is called once per frame
    void Update()
    {
        GameController = GameObject.Find("GameController");
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        Debug.DrawRay(transform.position, fwd * 10, Color.green);


        if (Physics.Raycast(transform.position, fwd, out hit, 10))
        {
            if (hit.collider.tag == "Interactable")
            {

                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("raycasttest");
                    activatablething = hit.collider.gameObject;
                    interactobj();

                    Debug.Log("raycasttest2");
                    
                    //pickup activate = activatablething.GetComponent<pickup>();
                    //activate.activation = true;
                }
            }
        }
    }

    void interactobj()
    {
        if (activatablething.name == "puzzle1activator")
        {
            activatablething.GetComponent<puzzle1>().isplaying = true;
            activatablething.GetComponent<puzzle1>().startpuzzle();
            GameController.GetComponent<tasks>().task = 1;
            if (GameController.GetComponent<pause>().gopause == false)
            {
                GameController.GetComponent<pause>().gopause = true;
                activatablething = null;
            }
        }
    }
}
