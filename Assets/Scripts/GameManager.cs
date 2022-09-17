using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool hasGameEnded;

  public float restartDelay = 1f;

  public void EndGame()
  {
    if (!hasGameEnded)
    {
      hasGameEnded = true;
      Debug.Log("END GAME");
      Invoke("Restart", restartDelay);
    }
  }
  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
