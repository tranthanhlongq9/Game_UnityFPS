using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingGame2 : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("AutoSave", 4);
    }
}
