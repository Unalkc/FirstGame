﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompelete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
