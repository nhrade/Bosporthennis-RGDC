using UnityEngine;
using System.Collections;

public class UpdateDisplacement : MonoBehaviour {

    private GameObject ship;
	// Use this for initialization
	void Start () {
        ship = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        GameObject origin = GameObject.Find("Origin Point");

        guiText.text = "Displacement: " + Mathf.Round(Vector2.Distance(ship.transform.position, origin.transform.position));
	}
}
