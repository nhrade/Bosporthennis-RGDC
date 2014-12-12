using UnityEngine;
using System.Collections;

public class ShipCollision : MonoBehaviour {

    public GameObject explosion;
    bool gameOver, restart;
	// Use this for initialization
	void Start () {
	    gameOver = false;
        restart = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (gameOver)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
            else if (Input.GetKey(KeyCode.R))
            {
                GameObject[] objects = UnityEngine.Object.FindObjectsOfType<GameObject>();
                foreach (GameObject g in objects)
                {
                    if (g.activeInHierarchy)
                    {
                        g.SendMessage("OnRestart");
                    }
                }
            }
            
        }
	}

    void OnRestart()
    {
        Application.LoadLevel(0);
    }

    void Awake()
    {
        explosion = GameObject.Find("Explosion");
        explosion.audio.mute = true;
        Time.timeScale = 1.0f;
    }

    void EndGame()
    {
        gameOver = true;
        
    }


    void OnGUI()
    {
        if (gameOver && !restart)
        {
            GUILayout.Label("Ship Destroyed! r to restart, esc to quit.");
            Time.timeScale = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Planet" || coll.gameObject.tag == "Comet")
        {
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            explosion.audio.mute = false;
            explosion.audio.Play();
            EndGame();
        }
    }
}
