using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
