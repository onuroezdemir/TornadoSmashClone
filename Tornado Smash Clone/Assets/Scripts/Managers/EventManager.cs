using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent OnLevelStarted = new UnityEvent();
    public static UnityEvent OnLevelCompleted = new UnityEvent();
    public static UnityEvent OnLevelChanged = new UnityEvent();

   

   
}
