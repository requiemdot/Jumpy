using UnityEngine;
using System.Collections;

public delegate void KeyGet(Key sender);
public class Key : MonoBehaviour {

    public event KeyGet keyGet = null;


    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D inCollider)
    {
        keyGet(this);
        Destroy(this.gameObject);
    }

}
