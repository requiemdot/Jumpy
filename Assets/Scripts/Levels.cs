using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Levels : MonoBehaviour {

    Queue<GameObject> m_levels = new Queue<GameObject>(5);
    List<Key> m_keys = new List<Key>();
    List<Transform> m_shelfs = new List<Transform>();
    public Ball ball;
    GameObject m_currentLevel;
    public GameObject exits;
    exit m_exit;

    void OnKeyGet(Key sender)
    {
        m_keys.Remove(sender);
        if (m_keys.Count == 0)
        {
            exits.renderer.enabled = true;
        }
     
    }
    void OnLevelExit(exit sender)
    {
        //
        //current level destoy
        Destroy(m_currentLevel.gameObject);
        foreach (GameObject item in m_levels)
        {
            item.transform.Translate(new Vector3(0, -60, 0));
        }
        
        m_currentLevel = m_levels.Dequeue();
        InitializeLevel();
    }
	// Use this for initialization
	void Start () {
        for (int i = 1; i < 6; i++)
        {
            m_levels.Enqueue(GameObject.Find("Level_" + i));
        }
        m_currentLevel = m_levels.Dequeue();
        InitializeLevel();  
	}

    void InitializeLevel()
    {
        exits.renderer.enabled = false;
        Transform[] currentLevelTransforms = m_currentLevel.GetComponentsInChildren<Transform>();
        foreach (Transform item in currentLevelTransforms)
        {

            if (item.ToString().IndexOf("key") >= 0)
            {
                Key temp = item.gameObject.GetComponent<Key>();
                Debug.Log(temp);
                temp.keyGet += OnKeyGet;
                m_keys.Add(temp);
            }
            if (item.ToString().IndexOf("Shelf") >= 0)
            {
                m_shelfs.Add(item);
            }
            if (item.ToString().IndexOf("exit") >= 0)
            {
                m_exit = item.gameObject.GetComponent<exit>();
                m_exit.levelExit += OnLevelExit;
            }
            //add exit
            //floor and celling add to this --------------------------------------
        }
        //ball.Shelfs = m_shelfs;
    }
	// Update is called once per frame
	void Update () {
        
	}

    

    public int keyNum { get; set; }
}
