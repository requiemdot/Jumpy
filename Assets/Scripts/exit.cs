using UnityEngine;
using System.Collections;

public delegate void LevelExit(exit sender);
public class exit : MonoBehaviour {

    public event LevelExit levelExit = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D inCollider)
    {
        levelExit(this);
        Destroy(this.gameObject);
    }
}
