using UnityEngine;

public class CameraController : MonoBehaviour
{

    private float rotationSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * -Input.GetAxis("Mouse Y"), 0, 0);

        if (transform.rotation.eulerAngles.x > 50 && transform.rotation.eulerAngles.x < 100)
        {
            transform.rotation = Quaternion.Euler(50, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
        if (transform.rotation.eulerAngles.x < 1)
        {
            transform.rotation = Quaternion.Euler(1, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }

    }
}