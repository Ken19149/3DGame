using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    bool gameEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel(){

        completeLevelUI.SetActive(true);

    }
    public void GameOver(){

        if (gameEnded == false){
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

}
