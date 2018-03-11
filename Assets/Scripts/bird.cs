using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour {

    public float speed = 2;
    public float force = 300;
  


    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetMouseButtonDown(0) &&  (! UIScript.isPaused()))   
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

        }
    }

    void onCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
