using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequense1 : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
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
        Cam5.SetActive(false);
        Audio.Play();
        yield return new WaitForSeconds(8);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        yield return new WaitForSeconds(7);
        Cam3.SetActive(true);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        yield return new WaitForSeconds(10);
        Cam4.SetActive(true);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam5.SetActive(false);
        yield return new WaitForSeconds(10);
        Cam5.SetActive(true);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        yield return new WaitForSeconds(10);
        Audio.Stop();
        Cam5.SetActive(false);
        CamPlayer.SetActive(true);
        UI.SetActive(true);
    }
}
