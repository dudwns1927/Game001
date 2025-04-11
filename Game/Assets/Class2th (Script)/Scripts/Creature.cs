using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Stats stat;
    public Creature()
    {
        stat = new Stats();
        stat.name = "Bear";
        stat.level = 5;
        stat.health = 150;

        Debug.Log("Creature");
    }

}
