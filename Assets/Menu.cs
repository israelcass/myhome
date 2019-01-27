using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     void Start(){
         Cursor.visible = true;
         Screen.lockCursor = false;
     }
    public void PlayGame() {
        SceneManager.LoadScene("Room");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
