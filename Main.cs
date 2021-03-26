using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // * Linq needed


public class Main : MonoBehaviour
{
    public string[] names = {"uno", "dos", "tres", "quatro"};

    void Start()
    {
        var nameFound = names.Contains("uno");
        Debug.Log("Found it");

        // foreach(var name in names)
        // {
        //     if(name == "uno")
        //     {
        //         Debug.Log("Found it");
        //     }
        // }
    }
}
