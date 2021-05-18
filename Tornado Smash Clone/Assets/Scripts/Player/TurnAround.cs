using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Vector3 rotateSpeed = Vector3.zero;
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}
