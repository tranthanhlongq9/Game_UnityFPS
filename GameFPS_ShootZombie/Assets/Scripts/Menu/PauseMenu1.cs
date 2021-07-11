using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject wpBase;

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                isPaused = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;

                AudioListener.pause = false;
                Cursor.visible = false;

                player.GetComponent<FirstPersonController>().enabled = true;
                //wpBase.GetComponent<WeaponBase>().enabled = true;

                GameObject.FindWithTag("WptBase").GetComponent<WeaponBase>().enabled = true;


            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;

                AudioListener.pause = true;
                Cursor.visible = true;

                player.GetComponent<FirstPersonController>().enabled = false;
                //wpBase.GetComponent<WeaponBase>().enabled = false;

                GameObject.FindWithTag("WptBase").GetComponent<WeaponBase>().enabled = false;
            }
        }

    }

    public void ResumeBtn()
    {
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        AudioListener.pause = false;
        player.GetComponent<FirstPersonController>().enabled = true;
        GameObject.FindWithTag("WptBase").GetComponent<WeaponBase>().enabled = true;
    }


    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
