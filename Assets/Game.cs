using UnityEngine;
using System.Collections;
using System.Linq;

public class Game : MonoBehaviour {

	public GameObject gui;
	public GameObject player;	
	public GameObject bullet;
	
	public float timeLastBulletFired = 0f;
	public float minTimeBetweenBullets = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButton( "Jump" ) ){
			if( Time.fixedTime > timeLastBulletFired + minTimeBetweenBullets ){
				timeLastBulletFired = Time.fixedTime;
				Instantiate( bullet , player.transform.position , new Quaternion() );
			}
		}
		

		gui.guiText.text = Input.GetAxis("Horizontal").ToString();
	}
}