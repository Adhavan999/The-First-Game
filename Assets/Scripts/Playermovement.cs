using UnityEngine;

public class Playermovement : MonoBehaviour {
    public Rigidbody player;
    public float forwardforce = 1000f,sidewardforce = 500f;
  
	void FixedUpdate () {
        player.AddForce(0, 0, forwardforce   * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            player.AddForce(sidewardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(-sidewardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (player.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }
     }
}
