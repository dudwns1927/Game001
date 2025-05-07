using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;

    private void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Debug.Log(ray.origin);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                GameObject prefab = raycastHit.collider.gameObject;

                if(prefab.transform.GetChild(0).gameObject.activeSelf)
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(true);
                }

                //raycastHit.collider.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log(raycastHit.collider.gameObject.name);
                Debug.Log(raycastHit.point);

            }
        }
    }
}
