using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnLevelChanged.AddListener(NextLevel);
    }

    private void OnDisable()
    {
        EventManager.OnLevelChanged.RemoveListener(NextLevel);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
