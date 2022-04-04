using UnityEngine;

public class CollisionForPlayer : MonoBehaviour
{
    public Movement pmovement; //reference to "Movement" script"

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "End")
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
