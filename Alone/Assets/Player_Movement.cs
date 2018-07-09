using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public float movementSpeed = 3f;

	void Update () 
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		}
	}
}
