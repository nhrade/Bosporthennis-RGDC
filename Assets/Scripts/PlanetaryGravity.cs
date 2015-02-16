using UnityEngine;
using System.Collections;

public class PlanetaryGravity : MonoBehaviour {


    public GameObject ship;
    public const float GRAVITY_CONST = 0.3f;

    private float calcGravity(GameObject o){
        return Mathf.Log((GRAVITY_CONST * rigidbody2D.mass * o.rigidbody2D.mass)) / Mathf.Pow(
            Vector2.Distance(transform.position, o.transform.position), 2);
    }

	// Use this for initialization
	void Start () {
        
        ship = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = -(ship.transform.position - transform.position);
        ship.rigidbody2D.AddForce(calcGravity(ship) * direction);

        foreach (GameObject comet in GameObject.FindGameObjectsWithTag("Comet"))
        {
            Vector2 cometDirection = -(comet.transform.position - transform.position);
            comet.rigidbody2D.AddForce(calcGravity(comet) * cometDirection);
        }
	}
}
