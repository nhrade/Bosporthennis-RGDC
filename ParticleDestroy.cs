using UnityEngine;
using System.Collections;

public class ParticleDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 4);
	}
}
