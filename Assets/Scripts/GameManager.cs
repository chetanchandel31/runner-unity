using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool hasGameEnded;

  public float restartDelay = 1f;

  public GameObject levelCompleteUi;

  public void LoseGame()
  {
    if (!hasGameEnded)
    {
      hasGameEnded = true;
      Invoke("Restart", restartDelay);
    }
  }
  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void CompleteLevel()
  {
    levelCompleteUi.SetActive(true);
    // "loosing because of falling" part won't run because it is part of `PlayerMovement` script
    FindObjectOfType<PlayerMovement>().enabled = false;
  }
}
