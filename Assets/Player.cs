using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float limitLeft = -10f;
	float limitRight = 10f;
	float speedFactor = 0.1f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis( "Horizontal" );

		var p = gameObject.transform.position;
		p.x += h * speedFactor;

		if(p.x < limitLeft){
			p.x = limitLeft;
		}

		if( p.x > limitRight ){
			p.x = limitRight;
		}

		gameObject.transform.position = p;
	}
}