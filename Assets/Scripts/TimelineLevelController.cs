using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineLevelController : MonoBehaviour {

    public LevelChanger LevelChanger;

	// Use this for initialization
	void OnEnable () {
        Debug.Log("L");
        LevelChanger.FadeToNextLevel();
    }
	
}
