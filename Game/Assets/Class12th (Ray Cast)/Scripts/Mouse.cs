using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;

    private void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Debug.Log(ray.origin);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {
                raycastHit.collider.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log(raycastHit.collider.gameObject.name);
                Debug.Log(raycastHit.point);
                Debug.Log(raycastHit.normal);
                Debug.Log(raycastHit.distance);
            }
        }
    }
}
