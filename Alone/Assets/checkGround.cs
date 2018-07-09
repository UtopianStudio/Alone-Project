using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGround : MonoBehaviour {
   
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "terrain") {
            Player_Movement.IsGrounded = true;
        }

        Debug.Log("Grounded");
    }
    void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "terrain")
        {
            Player_Movement.IsGrounded = false;
        }

        Debug.Log("Not Ground" + Player_Movement.IsGrounded);
    }
}
