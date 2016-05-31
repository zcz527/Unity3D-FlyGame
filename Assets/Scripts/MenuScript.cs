using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    private GUISkin skin;

    void Start()
    {
        skin = Resources.Load("GUISkin") as GUISkin;
    }

    void OnGUI()
    {
        const int buttonWidth = 128;
        const int buttonHeight = 60;
        GUI.skin = skin;
        Rect buttonRect = new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight);

        if (GUI.Button(buttonRect, "Start"))
        {
            Application.LoadLevel("Fly");
        }
    }
}
