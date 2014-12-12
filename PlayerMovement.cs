using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float force, angle, velocity;
    public const float MAX_VELOCITY = 0.2f;
    
	void Start () {
        velocity = 0;
	}

  
    void OnRestart()
    {
        transform.position = new Vector3(0, 0, 0);
        rigidbody2D.velocity = new Vector2(0, 0);
    }

	void FixedUpdate () {
        angle = transform.rotation.z * Mathf.Deg2Rad;
        
        transform.position += new Vector3(rigidbody2D.velocity.x, rigidbody2D.velocity.y, 0);
        Debug.Log(new Vector3(rigidbody2D.velocity.x, rigidbody2D.velocity.y, 0));
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.velocity = (Vector2)transform.TransformDirection(Vector3.up) * velocity;
            if(velocity < MAX_VELOCITY)
                velocity += 0.001f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Quaternion q = transform.rotation;

            q *= Quaternion.EulerAngles(new Vector3(0, 0, 0.1f));
            rigidbody2D.rotation = q.z;
            transform.rotation = q;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Quaternion q = transform.rotation;

            q *= Quaternion.EulerAngles(new Vector3(0, 0, -0.1f));
            rigidbody2D.rotation = q.z;
            transform.rotation = q;
        }
	}
}
