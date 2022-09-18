using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool hasGameEnded;

  public float restartDelay = 1f;

  public GameObject levelCompleteUi;

  public void EndGame()
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
  }
}
