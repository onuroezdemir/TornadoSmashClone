
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tornado : MonoBehaviour
{

    public Transform tornadoCenter;

    [Space]
    [SerializeField]
    private float force;

    [Space]
    [SerializeField]
    private float forceY = 0.001f;

    [Space]
    [SerializeField]
    private Vector3 scaleDown = Vector3.zero;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollectableObject")
        {
           
            StartCoroutine(PullObject(other,true));
            if (other.GetComponent<StickmanAgent>())
            {
                other.GetComponent<StickmanAgent>().enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CollectableObject")
        {
            StartCoroutine(PullObject(other, false));
        }
    }

    IEnumerator PullObject(Collider collider, bool isPull)
    {
        if (isPull&&collider!=null)
        {
         
            Vector3 ForceDirection =new Vector3((tornadoCenter.position.x - collider.transform.position.x),0.0001f, (tornadoCenter.position.z - collider.transform.position.z));
            collider.GetComponent<Rigidbody>().AddForce(ForceDirection.normalized*force*Time.deltaTime);     
            yield return 10;
            StartCoroutine(PullObject(collider, isPull));
        }
    }

}
