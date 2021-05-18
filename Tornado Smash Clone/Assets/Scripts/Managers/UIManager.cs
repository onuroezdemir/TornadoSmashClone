using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private GameObject currentLevel;
    private GameObject nextLevel;

    private Text currentLevelText;
    private Text nextLevelText;

    private GameObject startCanvas;

    private void Awake()
    {
        currentLevel = GameObject.Find("CurrentLevelText");
        nextLevel = GameObject.Find("NextLevelText");

        currentLevelText = currentLevel.GetComponent<Text>();
        nextLevelText = nextLevel.GetComponent<Text>();

        startCanvas = GameObject.Find("StartCanvas");

        currentLevelText.text = SceneManager.GetActiveScene().buildIndex.ToString();
        int nextLevelValue = SceneManager.GetActiveScene().buildIndex + 1;
        nextLevelText.text = nextLevelValue.ToString();
    }

    private void OnEnable()
    {
        EventManager.OnLevelStarted.AddListener(StartGame);
    }
    private void OnDisable()
    {
        EventManager.OnLevelStarted.RemoveListener(StartGame);
    }

    public void StartGame()
    {
        startCanvas.SetActive(false);
    }
}
