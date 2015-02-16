using UnityEngine;
using System.Collections;

public class NewComet : MonoBehaviour {
    const int multiplier = 25;

	// Use this for initialization
	void Start () {
        
        renderer.material.color = new Color(Random.value, Random.value, Random.value);
        float scale = Random.Range(0.2f, 0.5f);
        transform.localScale = new Vector3(scale, scale, 0);
        rigidbody2D.mass = scale*4;
        
        int xvel = Random.Range(0, 13) * multiplier;
        int yvel = Random.Range(0, 9) * multiplier;
        xvel = Mathf.Abs(xvel) < 4 ? (Random.Range(4, 6) - 5) * multiplier : xvel - (7 * multiplier);
        yvel = Mathf.Abs(yvel) < 4 ? (Random.Range(4, 6) - 5) * multiplier : yvel - (5 * multiplier);
        rigidbody2D.AddForce(new Vector2(xvel, yvel));
        particleSystem.startColor = renderer.material.color;
	}
	

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Planet")
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
