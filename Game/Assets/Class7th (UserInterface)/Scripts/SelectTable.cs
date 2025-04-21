using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTable : MonoBehaviour
{
    [SerializeField] Text titleText;


    public void Entered() {
        titleText.fontSize = 100;
        Debug.Log("Entered");
    }

    public void Exited() {
        titleText.fontSize = 75;
        Debug.Log("Exited");
    }

    public void Select() {
        titleText.fontSize = 50;
        Debug.Log("Selected");
    }

}
