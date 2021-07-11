using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCellOpen20 : MonoBehaviour
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
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim20");
                CreakSound.Play();
            }
        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
