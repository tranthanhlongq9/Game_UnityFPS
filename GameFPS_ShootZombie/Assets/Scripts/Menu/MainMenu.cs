using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //public GameObject menuMain;

    //public bool isload;

    // Update is called once per frame
    void Update()
    {
        
    
    }
    
    public void Play()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Quit()
    {
        Debug.Log("Bạn đã bấm quit game");
        Application.Quit();
    }

    List<int> widths = new List<int>() {1024, 1280 , 1440};
    List<int> heights = new List<int>() {720, 768, 800};

    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullscreen(bool _fullScreen)
    {
        Screen.fullScreen = _fullScreen;
    }

}
