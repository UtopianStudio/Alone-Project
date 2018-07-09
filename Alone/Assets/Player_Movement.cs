using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public float jumpPower = 900;

    //local variable
    Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    //fix update run smoot on low fps
    void FixedUpdate()
    {
        //axis key can change on edit -> project seting -> input
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(horizontal, 0, 0);
        if (horizontal >= 0.1f || horizontal <= 0.1f)
        {
            Movement(move);
        }

        //jump [default : space key]
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpPower);
            Debug.Log(Time.fixedDeltaTime);
        }

    }
    void Movement(Vector3 _dir)
    {
        transform.Translate(_dir * movementSpeed * Time.fixedDeltaTime);
    }
}
