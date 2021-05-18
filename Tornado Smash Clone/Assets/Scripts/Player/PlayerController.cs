using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 1f;

    Vector3 firstTouchPos = Vector3.zero;
    Vector3 deltaTouchPos = Vector3.zero;
    Vector3 direction = Vector3.zero;

    Rigidbody body;

    [Space]
    [SerializeField]
    private float bounds = 20f;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), transform.position.y, Mathf.Clamp(transform.position.z, -bounds, bounds));
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EventManager.OnLevelStarted?.Invoke();
            firstTouchPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaTouchPos = Input.mousePosition - firstTouchPos;
            direction = new Vector3(deltaTouchPos.x, 0f, deltaTouchPos.y);

            body.velocity = direction.normalized * speed;

            
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }
}
