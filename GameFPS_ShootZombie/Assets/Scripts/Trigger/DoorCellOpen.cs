using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour
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
        if(TheDistance <= 3)
        {
            ActionDisplay.GetComponent<Text>().text = "Nhấn [ C ]";
            ActionText.GetComponent<Text>().text = "Ngồi Xuống";
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
