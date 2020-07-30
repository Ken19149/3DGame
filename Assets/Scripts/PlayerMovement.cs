using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rigidbody;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    void FixedUpdate(){

        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidbody.position.y < -1){
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
