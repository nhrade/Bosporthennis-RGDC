using UnityEngine;
using System.Collections;

public class NewPlanet : MonoBehaviour {

	
	void Start () {
        renderer.material.color = new Color(Random.value, Random.value, Random.value);
        float scale = Random.RandomRange(0.9f, 2.0f);
        transform.localScale = new Vector3(scale, scale, 0);
        rigidbody2D.mass = scale * 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
