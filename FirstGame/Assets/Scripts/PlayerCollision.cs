using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player_Movement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();


        }



    }
}
 
