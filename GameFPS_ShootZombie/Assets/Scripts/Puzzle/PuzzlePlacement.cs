using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePlacement : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject RecommendText;
    //public GameObject ExtraCross;
    public GameObject puzzlePieces;
    public string nameAni;
    public GameObject UfoEG;
    public GameObject blockWall;

    public GameObject wall;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;       
    }

    void OnMouseOver()
    {
        if(TheDistance <= 3)
        {
            RecommendText.GetComponent<Text>().text = "Hãy kiếm đủ 2 mảnh ghép để mở";
            RecommendText.SetActive(true);
        }
        if (GlobalInventory.leftPuzzle == true && GlobalInventory.rightPuzzle == true) 
        {
            if (TheDistance <= 3)
            {
                RecommendText.SetActive(false);
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
                    puzzlePieces.SetActive(true); // bật full mảnh ghép
                    wall.GetComponent<Animator>().Play(nameAni);                    
                    blockWall.SetActive(false);

                    StartCoroutine(UFODropDown());
                }
            }
        }
        
    }

    IEnumerator UFODropDown() //UFO sau 5s sẽ xuất hiện
    {
        yield return new WaitForSeconds(6);
        UfoEG.SetActive(true);
    }

    void OnMouseExit()
    {
        RecommendText.SetActive(false);
        //ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
   
}
