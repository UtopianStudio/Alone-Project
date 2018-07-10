using UnityEngine;

public class checkGround : MonoBehaviour {
   
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "terrain") {
            Player_Movement.IsGrounded = true;
        }
    }

    void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "terrain")
        {
            Player_Movement.IsGrounded = false;
        }
    }
}
