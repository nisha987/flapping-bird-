using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {

    public float speed = 0;
    public float timeBetweenReverse = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        InvokeRepeating("Reverse", 0, timeBetweenReverse);
	}

    void Reverse()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
