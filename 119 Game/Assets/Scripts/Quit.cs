using Platformer.UI;
using System.Collections;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.InputSystem;

// Quits the player when the user hits escape

public class Quit : MonoBehaviour
{
    // All of these were for repurposing for exiting settins
    [SerializeField] private bool isStartScreen;
    private bool lastFrameExit;

    void Update()
    {
        if (Keyboard.current.deleteKey.isPressed || Keyboard.current.escapeKey.isPressed || Keyboard.current.backspaceKey.isPressed)
        {
            if (isStartScreen)
            {
                GameObject canvas = GameObject.Find("UI Canvas");
                GameObject controls = canvas.transform.Find("Controls").gameObject;
                if (controls != null && controls.activeInHierarchy)
                {
                    //controls.SetActive(false);
                    canvas.GetComponent<MainUIController>().SetActivePanel(0);
                    lastFrameExit = true;
                }
            }

           

            if (!lastFrameExit)
            {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
        else
        {
            lastFrameExit= false;
        }
    }
}