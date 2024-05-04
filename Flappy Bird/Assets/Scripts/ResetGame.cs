using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      string currentSceneName = SceneManager.GetActiveScene().name;
      SceneManager.LoadScene(currentSceneName);
    }
  }
}
