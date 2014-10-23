using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    public GameObject levels;

	// Use this for initialization
	void Start () 
    {
       // Debug.Log(levels.gameObject.tag == "Key");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.y = Screen.height - mousePos.y;            

            if(ButtonLeftRect.Contains(mousePos))
            {
                ball.LeftKey();
            }
            if (ButtonRightRect.Contains(mousePos))
            {
                ball.RightKey();
            }
            if (ButtonUpRect.Contains(mousePos))
            {
                ball.UpKey();
            }
            if (ButtonDownRect.Contains(mousePos))
            {
                ball.DownKey();
            }
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public Ball ball;

    public Texture2D LeftBtnTexture = null;
    public Texture2D RightBtnTexture = null;
    public Texture2D UpBtnTexture = null;
    public Texture2D DownBtnTexture = null;

    public float ButtonSide = 50.0f;

    Rect ButtonLeftRect;
    Rect ButtonRightRect;
    Rect ButtonUpRect;
    Rect ButtonDownRect;

    void OnGUI()
    {
        float delim = 5.0f;
        float x = delim;
        ButtonSide = Screen.height * 0.15f;
        float y = Screen.height * 0.5f - ButtonSide / 2;        


        //Left'n'Right buttons
        ButtonLeftRect = new Rect(x, y, ButtonSide, ButtonSide);
        x += ButtonSide + delim;
        ButtonRightRect = new Rect(x, y, ButtonSide, ButtonSide);

        //Up'n'Down buttons
        x = Screen.width - 2f * ButtonSide;
        y -= ButtonSide / 2;
        ButtonUpRect = new Rect(x, y, ButtonSide, ButtonSide);
        y += ButtonSide + delim;
        ButtonDownRect = new Rect(x,y, ButtonSide, ButtonSide);

        if (GUI.Button(ButtonLeftRect, LeftBtnTexture))
        {
            //ball.LeftKey();
        }
        if (GUI.Button(ButtonRightRect, RightBtnTexture))
        {
            //ball.RightKey();
        }

        if (GUI.Button(ButtonUpRect, UpBtnTexture))
        {
            //ball.UpKey();
        }
        if (GUI.Button(ButtonDownRect, DownBtnTexture))
        {
            //ball.DownKey();
        } 
    }
}
