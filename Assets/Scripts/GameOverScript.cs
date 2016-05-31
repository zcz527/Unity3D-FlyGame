using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour
{

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;
        Rect retryButton = new Rect(Screen.width / 2 - (buttonWidth / 2), (Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight);
        if (GUI.Button(retryButton, "Retry"))
        {
            Application.LoadLevel("Fly");
        }

        Rect toMenu = new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight);
        if (GUI.Button(toMenu, "Back to menu"))
        {
            Application.LoadLevel("Menu");
        }
    }
}
