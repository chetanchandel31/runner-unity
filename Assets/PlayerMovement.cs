
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public Rigidbody rb; // reference to player's rigid body component
  public float forwardForce = 2000f;
  public float sidewaysForce = 500f;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("Hello");
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float deltaTime = Time.deltaTime;

    rb.AddForce(0, 0, forwardForce * deltaTime); // add forward force to z axis


    if (Input.GetKey("d"))
    {
      rb.AddForce(sidewaysForce * deltaTime, 0, 0);
    }

    if (Input.GetKey("a"))
    {
      rb.AddForce(-sidewaysForce * deltaTime, 0, 0);
    }
  }

}
