using System;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 3f;
    private float currentSpeed = 0f;
    private float speedSmoothVelocity = 0f;
    private float speedSmoothTime = 0.1f;
    private float rotationSpeed = 0.1f;
    private float gravity = 3f;
    private float desiredrotationangle = 0;
    Vector3 movementVector = Vector3.zero;
    private Transform mainCameraTransform = null;
    private CharacterController controller = null;
    private Animator animator = null;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        mainCameraTransform = Camera.main.transform;

    }
     void Update()
    {
        //movementVector.y -= gravity;
        //controller.Move(movementVector * Time.deltaTime);
        Move();
    }
    private void Move()
    {
        Vector3 movementinput = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        Vector3 forward = mainCameraTransform.forward;
        Vector3 right = mainCameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = (forward * movementinput.z+ right*movementinput.x).normalized;
        Vector3 gravityVector = Vector3.zero;
       if (!controller.isGrounded)
       {
         gravityVector.y -= gravity;
       }
        if (desiredMoveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection),rotationSpeed);
        }
        float targetSpeed = movementSpeed * movementinput.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

        controller.Move(desiredMoveDirection * currentSpeed * Time.deltaTime);
        controller.Move(gravityVector * Time.deltaTime);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            
            animator.SetFloat("Forward", 1.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetFloat("Forward", 0.1f);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            animator.SetFloat("Backward", 2.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetFloat("Backward", 0.1f);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {

            animator.SetFloat("Run", 3.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
        {

            animator.SetFloat("Run", 3.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)) || Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetFloat("Run", 1.7f);
        }
        if (Input.GetKey(KeyCode.Space))
        {

            animator.SetFloat("Jump", 4.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space) )
        {
            animator.SetFloat("Jump", 1.7f);
        }


        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {

            animator.SetFloat("Run Backward", 5.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift))
        {

            animator.SetFloat("Run Backward", 5.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if ((Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)) || Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetFloat("Run Backward", 2.7f);
        }
        if (Input.GetKey(KeyCode.Space)&& Input.GetKey(KeyCode.S))
        {

            animator.SetFloat("Jump Backward", 6.5f * movementinput.magnitude, speedSmoothTime, Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space)|| Input.GetKeyUp(KeyCode.S))
        {
            animator.SetFloat("Jump Backward", 2.7f);
        }
        //animator.SetFloat("speedPercent", 1.5f*movementinput.magnitude,speedSmoothTime,Time.deltaTime);
    }
    
}
