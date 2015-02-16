using UnityEngine;
using System.Collections;

public class ProceduralGeneration : MonoBehaviour {
    GameObject player;
    private const float CHANCE = 0.2f;


    bool PlayerMoving()
    {
        return player.rigidbody2D.velocity.magnitude > 0;
    }
	
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}


    private void InstantiatePlanet(Vector2 dir)
    {
        GameObject planet = GameObject.Find("Planet");
        Instantiate(planet, new Vector3((player.transform.position.x + camera.orthographicSize) * dir.x,
            (player.transform.position.y + camera.orthographicSize) * dir.y), Quaternion.identity);
        

    }
	
	void Update () {
        if (PlayerMoving())
        {
            Vector2 direction = player.rigidbody2D.velocity.normalized;
            InstantiatePlanet(direction);
        }
	}
}
