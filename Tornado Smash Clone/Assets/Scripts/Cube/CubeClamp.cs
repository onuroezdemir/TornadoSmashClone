using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClamp : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float bounds;
    [SerializeField]
    private float boundY;

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), Mathf.Clamp(transform.position.y,-boundY,boundY), Mathf.Clamp(transform.position.z, -bounds, bounds));
    }
}
