using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequense : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject CamPlayer;
    public GameObject UI;
    public AudioSource Audio;

    void Start()
    {
        StartCoroutine(TheSequense());
        CamPlayer.SetActive(false);
    }

    IEnumerator TheSequense()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Audio.Play();
        yield return new WaitForSeconds(4);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        yield return new WaitForSeconds(4);
        Cam3.SetActive(true);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam4.SetActive(false);
        yield return new WaitForSeconds(3);
        Cam4.SetActive(true);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        Audio.Stop();
        Cam4.SetActive(false);
        CamPlayer.SetActive(true);
        UI.SetActive(true);
    }

    
}
