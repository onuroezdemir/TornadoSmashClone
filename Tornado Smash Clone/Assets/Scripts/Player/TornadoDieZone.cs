using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TornadoDieZone : MonoBehaviour
{

    [Space]
    [SerializeField]
    private Vector3 scaleDown = Vector3.zero;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollectableObject")
        {

            
            StartCoroutine(DestroyObject(other.gameObject, true));
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CollectableObject")
        {
            StartCoroutine(DestroyObject(other.gameObject, false));
        }
    }

    IEnumerator DestroyObject(GameObject collider, bool isDestroyable)
    {
        collider.transform.DOScale(scaleDown, 2f);
        yield return new WaitForSeconds(2f);
        if (isDestroyable)
        {
            CubeManager.instance.cubes.Remove(collider.gameObject);
            Destroy(collider);

        }


    }
}
