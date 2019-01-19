using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    //public Animator animator;
    private int levelToLoad;


	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            Debug.Log("current scene" + SceneManager.GetActiveScene().buildIndex);
            if (Input.GetAxis("Horizontal") > 0.1)
            {
                Debug.Log("going to scene" + SceneManager.GetActiveScene().buildIndex + 1);
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
            }
            else if (Input.GetAxis("Horizontal") < -0.1)
            {
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex - 1));
            }
        }
	}

    public void FadeToNextLevel() {
        Debug.Log("current scene" + SceneManager.GetActiveScene().buildIndex);
        Debug.Log("going to scene" + SceneManager.GetActiveScene().buildIndex + 1);
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        //animator.SetTrigger("FadeOut");
        SceneManager.LoadScene(levelToLoad);
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }



    public void FadeToPrevLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
