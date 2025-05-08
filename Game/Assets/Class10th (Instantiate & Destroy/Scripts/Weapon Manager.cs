using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] List<GameObject> weaponList;
    
    [SerializeField] Transform parentPosition;

    [SerializeField] int count = 0;
    //int currentIndex = 0;


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Attack();
        }
    }

    public void Swap() {
        weaponList[count].gameObject.SetActive(false);

        count = (count + 1) % weaponList.Count;

        weaponList[count].gameObject.SetActive(true);
    }


    void Start() {
        for (int i = 0; i < weapons.Length; i++) {
            GameObject clone = Instantiate(weapons[i], parentPosition);
            clone.gameObject.SetActive(false);
            weaponList.Add(clone);
        }

        weaponList[count].gameObject.SetActive(true);
    }

    public void Attack() {
        weaponList[count].GetComponent<Weapon>().Attack();
       // Attack logic here
        Debug.Log("Attacking with " + weaponList[count].name);
    }

}
