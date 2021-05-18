using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    private int cubesCountStart;
    private int cubesCount;

    private GameObject levelProgressObject;
    private Image levelProgressBar;

    public float progress;

    private void Start()
    {
        cubesCountStart = CubeManager.instance.cubes.Count;
        cubesCount = CubeManager.instance.cubes.Count;
        levelProgressObject = GameObject.Find("LevelProgressBar");
        levelProgressBar = levelProgressObject.GetComponent<Image>();
    }

    private void Update()
    {
        cubesCount = CubeManager.instance.cubes.Count;
        progress = (float)cubesCount / (float)cubesCountStart;
        levelProgressBar.fillAmount = progress;
    }


}
