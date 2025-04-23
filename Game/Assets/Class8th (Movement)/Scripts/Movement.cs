using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /*
    void Start() {
        transform.position = new Vector3(1, 1, 1);
    
        Debug.Log(transform.position);
    
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.W)) {
            transform.position += new Vector3(0, 0, 1);
            Debug.Log("W");
        }

        if(Input.GetKeyDown(KeyCode.A)) {
            transform.position += new Vector3(-1, 0, 0);
            Debug.Log("A");
        }

        if(Input.GetKeyDown(KeyCode.S)) {
            transform.position += new Vector3(0, 0, -1);
            Debug.Log("S");
        }

        if(Input.GetKeyDown(KeyCode.D)) {
            transform.position += new Vector3(1, 0, 0);
            Debug.Log("D");
        }
    }

    */
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 5.0f;
    
    
    void Update() {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;

    }
}
