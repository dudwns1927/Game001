using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] Text[] textList;
    [SerializeField] string[] titleList;

    private void Start() {
        for(int i = 0; i < textList.Length; i++) {
            textList[i].text = titleList[i];
        }

    }

    public void Excute() {
       textList[0].color = Color.green;
       
       Debug.Log("Execute");
    }

    public void Shop() {
        textList[1].color = Color.blue;
        
        Debug.Log("Shop");
    }

    public void Quit() {
        textList[2].color = Color.red;
        
        Debug.Log("Quit");
    }
}
