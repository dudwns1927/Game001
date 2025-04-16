using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [SerializeField] int strength = 15;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StrengthÀÇ °ª : " + strength);
    }

    
}
