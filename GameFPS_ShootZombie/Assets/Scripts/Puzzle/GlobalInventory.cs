using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool firstDoorKey = false;
    public static bool leftPuzzle = false;
    public static bool rightPuzzle = false;

    public bool internalDoorKey;
   
    // Update is called once per frame
    void Update()
    {
        internalDoorKey = firstDoorKey;
    }
}
