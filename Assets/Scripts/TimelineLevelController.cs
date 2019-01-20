using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineLevelController : MonoBehaviour {
    public OVRScreenFade ovrfade;
    // Use this for initialization
    void OnEnable () {
        StartCoroutine("Fade");
        Debug.Log("FinishedCoroutine");
    }

    IEnumerator Fade() 
    {
        Debug.Log("Fading Out");
        ovrfade.FadeOut();
        yield return new WaitForSeconds(8);//ovrfade.fadeTime
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
        yield return null;
    }
}
