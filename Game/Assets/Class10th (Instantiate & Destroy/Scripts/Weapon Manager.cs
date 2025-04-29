using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] List<GameObject> weaponList;
    
    [SerializeField] Transform parentPosition;

    void start() {
        for (int i = 0; i < weapons.Length; i++) {
            GameObject weapon = Instantiate(weapons[i], parentPosition);
            weaponList.Add(weapon);
        }
    }


}
