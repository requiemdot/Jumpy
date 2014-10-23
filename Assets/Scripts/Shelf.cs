using UnityEngine;
using System.Collections;

public class Shelf : MonoBehaviour {

	public Ball ball;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D inCollider)
	{
		//ToLeft();
		Vector2 inPos = inCollider.transform.position;
		Vector2 pos = this.transform.position;
		if(pos.y > inPos.y)
			ball.OnCeiling();
		else
			ball.OnGround();
	}

	void ToLeft(){
		transform.Rotate(0.0f,0.0f,-15.0f);
	}
}
