
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Playermovement Movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            Movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();

            

        }
        
    }
    

}
