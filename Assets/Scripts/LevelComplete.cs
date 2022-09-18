using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel()
  {
    // this is invoked from the level complete animation
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
