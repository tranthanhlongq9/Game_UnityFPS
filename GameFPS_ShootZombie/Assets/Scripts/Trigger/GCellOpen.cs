using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCellOpen : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;


    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 19)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
