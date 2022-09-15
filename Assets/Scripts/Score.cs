using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
  public Rigidbody player;
  public TextMeshProUGUI scoreText;

  // Update is called once per frame
  void Update()
  {
    Debug.Log(player.position.z + "hi");
    scoreText.SetText(player.position.z.ToString("0"));
  }
}
