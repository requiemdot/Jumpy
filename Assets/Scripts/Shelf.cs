using UnityEngine;
using System.Collections;

public class Shelf : MonoBehaviour {

	Ball m_Ball;
	// Use this for initialization
	void Start () 
	{
        if (m_Ball == null)
            m_Ball = GameObject.Find("Ball").GetComponent<Ball>();
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
            m_Ball.OnCeiling();
		else
            m_Ball.OnGround();
	}

	void ToLeft(){
		transform.Rotate(0.0f,0.0f,-15.0f);
	}
}
