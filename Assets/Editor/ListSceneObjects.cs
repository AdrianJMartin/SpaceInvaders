using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;


public class AJMAdditions : ScriptableObject
{	
	[MenuItem ("GameObject/List Scene Elements")]
	static void MenuListSceneElements()
	{
		Debug.Log( "List Scene Elements" );

		var gos = GameObject.FindObjectsOfType ( typeof( GameObject ) );

		var q = gos.Where( o => o.name == "Invader" ).Select(o=>o);

		foreach( GameObject go in q ){
			go.tag = "Invader";
			Transform t = go.GetComponent( typeof( Transform )) as Transform;

			string newName = string.Format( "invader-{0}-{1}" , 
			                              System.Convert.ToInt32( (t.position.x+9) / 1.5 +1 ), 
			                              System.Convert.ToInt32( (t.position.y-2) / 1.5 +1 )
			                              );
			Debug.Log( newName );
			go.name = newName;


		}
	}
}