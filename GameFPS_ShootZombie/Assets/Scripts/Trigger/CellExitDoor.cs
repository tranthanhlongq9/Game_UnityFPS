using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CellExitDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject TheDoor;
    //public AudioSource CreakSound;


    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.GetComponent<Text>().text = "Nhấn [ E ]";
            ActionText.GetComponent<Text>().text = "Escape";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);

                StartCoroutine(FadeToExit());
            }
        }

    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator FadeToExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
