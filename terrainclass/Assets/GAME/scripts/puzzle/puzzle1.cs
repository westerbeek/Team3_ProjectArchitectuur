using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class puzzle1 : MonoBehaviour
{
    public bool isplaying;


    public GameObject Door;
    
    public Image[] triggers;

    public int check;
    public bool finished;
    public GameObject GameController;


    // Start is called before the first frame update
    private void Start()
    {
        GameController = GameObject.Find("GameController");

        triggers[0] = GameObject.Find("Switch0").GetComponent<Image>();
        triggers[1] = GameObject.Find("Switch1").GetComponent<Image>();
        triggers[2] = GameObject.Find("Switch2").GetComponent<Image>();
        triggers[3] = GameObject.Find("Switch3").GetComponent<Image>();
        triggers[4] = GameObject.Find("Switch4").GetComponent<Image>();
    }
    public void startpuzzle()
    {

        check = 0;
        if (isplaying == false)
        {

            triggers[0].enabled = false;
            triggers[1].enabled = false;
            triggers[2].enabled = false;
            triggers[3].enabled = false;
            triggers[4].enabled = false;
        }
        else
        {
            triggers[0].enabled = true;
            triggers[1].enabled = true;
            triggers[2].enabled = true;
            triggers[3].enabled = true;
            triggers[4].enabled = true;

        }
        if (isplaying == true)
        {
            

            triggers[0].color = Color.green;
            triggers[1].color = Color.red;
            triggers[2].color = Color.green;
            triggers[3].color = Color.red;
            triggers[4].color = Color.green;
        }
    }

    // Update is called once per frame
    void finishcheck()
    {
        if (isplaying == true)
        {
            check = 0;
            for (int i = 0; i < 5; i++)
            {
                if (triggers[i].color == Color.green)
                {
                    check++;
                }
                else
                {
                    check = 0;
                }
            }
            if (check == 5)
            {
                finished = true;
                triggers[0].enabled = false;
                triggers[1].enabled = false;
                triggers[2].enabled = false;
                triggers[3].enabled = false;
                triggers[4].enabled = false;
                if (GameController.GetComponent<pause>().gopause == true)
                {
                    GameController.GetComponent<pause>().gopause = false;
                    GameController.GetComponent<tasks>().task = 2;

                }

            }
            else
            {
                finished = false;
            }
        }
    }
    public void switch0()
    {

        if (triggers[0].color == Color.red)
        {
            triggers[0].color = Color.green;
            
        }
        else
        {
            triggers[0].color = Color.red;
        }

        if (triggers[1].color == Color.red)
        {
            triggers[1].color = Color.green;
            
        }
        else
        {
            triggers[1].color = Color.red;
        }

        finishcheck();


    }
    public void switch1()
    {
        if (triggers[1].color == Color.red)
        {
            triggers[1].color = Color.green;
            
        }
        else
        {
            triggers[1].color = Color.red;
        }

        if (triggers[0].color == Color.red)
        {
            triggers[0].color = Color.green;
            
        }
        else
        {
            triggers[0].color = Color.red;
        }

        if (triggers[2].color == Color.red)
        {
            triggers[2].color = Color.green;
            

        }
        else
        {
            triggers[2].color = Color.red;
        }
        finishcheck();

    }
    public void switch2()
    {
        if (triggers[2].color == Color.red)
        {
            triggers[2].color = Color.green;
            
        }
        else
        {
            triggers[2].color = Color.red;
        }

        if (triggers[1].color == Color.red)
        {
            triggers[1].color = Color.green;
            
        }
        else
        {
            triggers[1].color = Color.red;
        }

        if (triggers[3].color == Color.red)
        {
            triggers[3].color = Color.green;
            

        }
        else
        {
            triggers[3].color = Color.red;
        }
        finishcheck();

    }
    public void switch3()
    {
        if (triggers[3].color == Color.red)
        {
            triggers[3].color = Color.green;
            
        }
        else
        {
            triggers[3].color = Color.red;
        }

        if (triggers[2].color == Color.red)
        {
            triggers[2].color = Color.green;
            
        }
        else
        {
            triggers[2].color = Color.red;
        }

        if (triggers[4].color == Color.red)
        {
            triggers[4].color = Color.green;
            

        }
        else
        {
            triggers[4].color = Color.red;
        }
        finishcheck();

    }
    public void switch4()
    {
        if (triggers[4].color == Color.red)
        {
            triggers[4].color = Color.green;
            
        }
        else
        {
            triggers[4].color = Color.red;
        }

        if (triggers[3].color == Color.red)
        {
            triggers[3].color = Color.green;
            
        }
        else
        {
            triggers[3].color = Color.red;
        }
        finishcheck();

    }
}
