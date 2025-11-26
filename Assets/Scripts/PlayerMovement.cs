using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpHeight;
    public float rotationSpeed = 2;
    private bool canJump = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = movementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movement, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movement, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, movement));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -movement));
        }
        transform.Rotate(0, rotationSpeed * Input.GetAxis("Mouse X"), 0);
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            GetComponent<Rigidbody>().linearVelocity = Vector3.up * jumpHeight;
            canJump = false;
        }
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1f))
        {
            if (hit.transform.CompareTag("Ground")) canJump = true; 
        }
    }
}
