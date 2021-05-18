using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public static CubeManager instance;

    public List<GameObject> cubes ;
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }

        foreach (Transform child in transform)
        {
            cubes.Add(child.gameObject);
        }
    }

    private void Update()
    {
        if (cubes.Count  <= 0)
        {
           
            EventManager.OnLevelCompleted?.Invoke();
        }
    }
}
