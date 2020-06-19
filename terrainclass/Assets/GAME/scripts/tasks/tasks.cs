using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tasks : MonoBehaviour
{
    public int task;
    public Text tasktext;
    // Start is called before the first frame update
    void Start()
    {
        if (tasktext == null)
        {
            GameObject taskobj = GameObject.Find("Tasktext");
            if (taskobj != null)
            {
                tasktext = GameObject.Find("Tasktext").GetComponent<Text>();
            }
        }
        task = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tasktext != null)
        {
            if (task == 0)
            {
                tasktext.text = "Click on the cube next to you to start the puzzle.";
            }
            if (task == 1)
            {
                tasktext.text = "Thank you for starting the puzzle.\nPlease finish the puzzle.";
            }
            if (task == 2)
            {
                tasktext.text = "Congratulations on beating the puzzle!";
            }
        }
    }
}
