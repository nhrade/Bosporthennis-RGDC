using UnityEngine;
using System.Collections;

public class FollowShip : MonoBehaviour {

    GameObject ship;
	// Use this for initialization
	void Start () {
        ship = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        camera.transform.position = new Vector3(ship.transform.position.x,
            ship.transform.position.y, -25);
    }
}
