using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleRightPickup : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject ExtraCross;
    public GameObject thePuzzleRight;

    public GameObject screenFade;
    public GameObject rightImg;
    public GameObject puzzleText;

    public GameObject fakeWall;
    public GameObject realWall;

    //public GameObject Particle;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;       
    }

    void OnMouseOver()
    {
        if(TheDistance <= 3)
        {
            //ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Nhặt mảnh ghép";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                //ExtraCross.SetActive(false); //khi di chuột vào sẽ có thêm hiệu ứng ở ống nhắm

                GlobalInventory.rightPuzzle = true;
                //Particle.SetActive(false);
                StartCoroutine(PuzzlePickedUp());
                
            }
        }
    }
    void OnMouseExit()
    {
        //ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator PuzzlePickedUp()
    {
        //fakeWall.SetActive(false);
        //realWall.SetActive(true);
        //puzzleText.GetComponent<Text>().text = ""; //set text cho puzzle text
        screenFade.SetActive(true);
        rightImg.SetActive(true);
        puzzleText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        screenFade.SetActive(false);
        rightImg.SetActive(false);
        puzzleText.SetActive(false);
        thePuzzleRight.SetActive(false);
    }
}
