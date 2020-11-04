using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuu : MonoBehaviour
{
  public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
