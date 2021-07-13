using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePlacement : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject ExtraCross;
    public GameObject puzzlePieces;
    public string nameAni;

    public GameObject wall;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;       
    }

    void OnMouseOver()
    {
        if (GlobalInventory.leftPuzzle == true && GlobalInventory.rightPuzzle == true) 
        {
            if (TheDistance <= 3)
            {
                //ExtraCross.SetActive(true);
                ActionText.GetComponent<Text>().text = "Đặt mảnh ghép";
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
                    puzzlePieces.SetActive(true);
                    wall.GetComponent<Animator>().Play(nameAni);

                }
            }
        }
        
    }
    void OnMouseExit()
    {
        //ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
   
}
