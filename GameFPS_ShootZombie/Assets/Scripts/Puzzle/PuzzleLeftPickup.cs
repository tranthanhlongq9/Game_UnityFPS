using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleLeftPickup : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject ExtraCross;
    public GameObject thePuzzleLeft;

    public GameObject screenFade;
    public GameObject leftImg;
    public GameObject puzzleText;

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

                GlobalInventory.leftPuzzle = true;
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
    IEnumerator PuzzlePickedUp() //show mảnh gắp lên cho ng chơi xem
    {
        screenFade.SetActive(true);
        leftImg.SetActive(true);
        puzzleText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        screenFade.SetActive(false);
        leftImg.SetActive(false);
        puzzleText.SetActive(false);
        thePuzzleLeft.SetActive(false);
    }
}
