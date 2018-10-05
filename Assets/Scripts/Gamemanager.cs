using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartdelay = 2f;

    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
