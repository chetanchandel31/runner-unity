using UnityEngine;

public class GameManager : MonoBehaviour
{
  bool hasGameEnded;

  public void EndGame()
  {
    if (!hasGameEnded)
    {
      hasGameEnded = true;
      Debug.Log("END GAME");
    }
  }
}
