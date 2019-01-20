using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineLevelController : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
        Debug.Log("L");
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }
	
}
