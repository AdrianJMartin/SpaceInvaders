using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{

		float birthTime = 0f;
		float deltaTime = 0f;
		
		float speedFactor = 3f;
	
		float upperYLimit = 13f;
		
		Vector3 startPosition;
	    
	    public void Awake(){
	    	startPosition = gameObject.transform.position;
			birthTime = Time.fixedTime;
			deltaTime = 0f;
		}

	
		void FixedUpdate ()
		{
			deltaTime = Time.fixedTime - birthTime;
			Vector3 p = gameObject.transform.position;
			p.y = startPosition.y + deltaTime * speedFactor;
			gameObject.transform.position = p;

			if (p.y > upperYLimit){
				Destroy( gameObject );
			}
			
		}

		// Update is called once per frame
		void Update ()
		{
		
		}
}
