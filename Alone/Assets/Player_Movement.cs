using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public float jumpPower = 900;
    public float turnSpeed = 10;
    public GameObject PlayerObject;
     Animator anim;
    public static bool IsGrounded; 
    //local variable
    Rigidbody rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = PlayerObject.GetComponent<Animator>();
       
    }
    //fix update run smoot on low fps
    void FixedUpdate()
    {
        //axis key can change on edit -> project seting -> input
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(horizontal, 0, 0);
        if (horizontal >= 0.1f || horizontal <= -0.1f)
        {
            Movement(move);
            if(IsGrounded)
                anim.SetBool("move", true);
            else anim.SetBool("move", false);
        } else if (horizontal <= 0.1f && horizontal >= -0.1f)
        {
            anim.SetBool("move", false);
        }

        //jump [default : space key]
        if (IsGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * jumpPower * Time.fixedDeltaTime);

                Debug.Log(IsGrounded);
            }
            anim.SetBool("jump", false);
        }
        else {
            anim.SetBool("jump", true);
        }

        Debug.Log(IsGrounded);
    }
    void Movement(Vector3 _dir)
    {
        transform.Translate(_dir * movementSpeed * Time.fixedDeltaTime);
        //rotate player
        if (_dir.x <= 0)
        {
            PlayerObject.transform.rotation = Quaternion.Slerp(PlayerObject.transform.rotation, Quaternion.Euler(0, 270, 0),Time.fixedDeltaTime * turnSpeed);
               
        }
        else {
            PlayerObject.transform.rotation = Quaternion.Slerp(PlayerObject.transform.rotation, Quaternion.Euler(0, 90, 0), Time.fixedDeltaTime * turnSpeed);
        }
    }
}
