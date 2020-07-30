using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public MoveLeft moveLeft;
    public MoveRight moveRight;
    void OnCollisionEnter(Collision collision){

        if(collision.collider.tag == "Obstacle"){
            movement.enabled = false;
            moveLeft.enabled = false;
            moveRight.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
