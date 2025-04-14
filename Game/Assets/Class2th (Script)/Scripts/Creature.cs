using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    private Stats stats = new Stats();
    public Creature()
    {      
        stats.Level = 1;
        stats.Health = 100;
        stats.Name = "Bear";

        Debug.Log("Level : " + stats.Level);
        Debug.Log("Level : " + stats.Health);
        Debug.Log("Level : " + stats.Name);

    }

}
