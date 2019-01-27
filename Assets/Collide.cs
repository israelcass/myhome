using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
	void OnTriggerEnter(Collider other) {
		if (other.tag == "lava") {
			SceneManager.LoadScene("DeathMenu");
		} else if (other.tag == "jar") {
			SceneManager.LoadScene("WinMenu");
		}
	}
}
