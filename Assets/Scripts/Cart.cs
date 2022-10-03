using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
             GetComponent<Rigidbody>().AddForce(transform.forward * 4, ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            GetComponent<Rigidbody>().velocity =Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 4, ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            GetComponent<Rigidbody>().velocity =Vector3.zero;
        } 
        // if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        //     GetComponent<Rigidbody>().transform.Rotate(0.0f, 30.0f, 0.0f, Space.Self);
        //                   
    }
}
