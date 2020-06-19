using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
		//Variables
		public float speed = 6.0F;
		public float jumpSpeed = 8.0F; 
		public float gravity = 20.0F;
		public bool ground;
		private Vector3 moveDirection = Vector3.zero;
          public GameObject GameController;

    private void Start()
    {
        
          GameController = GameObject.Find("GameController");

        
    }

        void Update()
    {
        if (GameController.GetComponent<pause>().gopause == false)
        {
            CharacterController controller = GetComponent<CharacterController>();
            // is the controller on the ground?

            if (controller.isGrounded)
            {
                ground = true;
                //Feed moveDirection with input.
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;

                //Jumping
                if (Input.GetButton("Jump") && GameController.GetComponent<pause>().gopause == false)
                {
                    moveDirection.y = +jumpSpeed;
                }
            }
            else
            {
                ground = false;
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), moveDirection.y, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection.x *= speed;
                moveDirection.z *= speed;
                moveDirection.y -= gravity * Time.deltaTime;
            }
            //Applying gravity to the controller

            //Making the character move
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}
	