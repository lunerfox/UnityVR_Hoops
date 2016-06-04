using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

enum GameStates {Menu, Game, GameOver};

public class LevelManager : MonoBehaviour {

    int currentIndex;
    public float timeTillNextLevelcfg = 0.0f;
    float timeTillNextLevel = 0.0f;

    // Use this for initialization
    void Start () {
        // Load Scene
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        // Reset the clock
        timeTillNextLevel = timeTillNextLevelcfg;
        // Reset the score if the game state being entered.
        if (currentIndex == (int)GameStates.Game) {
            FindObjectOfType<Scorekeeper>().resetScore();
        }
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Return)) {
            // Load Current Scene + 1 (Next Scene)
            SceneManager.LoadScene(currentIndex + 1);
        }

        //While the game is being played, count down the clock.
        if (timeTillNextLevelcfg > 0) {
            timeTillNextLevel -= Time.deltaTime;
            if (timeTillNextLevel < 0) {
                loadNextScene();
            }
        }
	}

    public void loadNextScene() {
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void loadPreviousScene() {
        SceneManager.LoadScene(currentIndex - 1);
    }

    public void loadStartScene() {
        SceneManager.LoadScene(0);
    }

    public float getTimeTilNextLevel() {
        return timeTillNextLevel;
    }
}
