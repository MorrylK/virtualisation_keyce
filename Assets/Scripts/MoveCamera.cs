using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float mouseX;
    //private float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");

        this.transform.Translate(Vector3.forward * verticalInput * Time.deltaTime);
        this.transform.Translate(Vector3.right * horizontalInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * mouseX * 50 * Time.deltaTime);
    }
}
