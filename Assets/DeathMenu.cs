using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Cursor.visible = true;
         Screen.lockCursor = false;        
    }

    public void PlayGame() {
        SceneManager.LoadScene("Room");
    }

    public void GoToMenu() {
        SceneManager.LoadScene("Menu");
    }
}
