using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;
    private int levelToLoad;


	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            if (Input.GetAxis("Horizontal") > 0.1)
            {
                FadeToNextLevel();
            }
            else if (Input.GetAxis("Horizontal") < -0.1)
            {
                FadeToPrevLevel();
            }
        }
	}

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToPrevLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
