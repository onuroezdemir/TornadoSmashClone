using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTornado : MonoBehaviour
{
    public GameObject ground;
    public GameObject groundCollectable;
    public GameObject tornadoArea;
    public GameObject tornadoDyingArea;
    public GameObject confetti;

    public GameObject successCanvas;

    public float scaleTornado = 15f;

    private void OnEnable()
    {
        EventManager.OnLevelCompleted.AddListener(LevelFinish);
    }

    private void OnDisable()
    {
        EventManager.OnLevelCompleted.RemoveListener(LevelFinish);
    }

  
    public void LevelFinish()
    {
        successCanvas.SetActive(true);
        ground.SetActive(false);
        groundCollectable.SetActive(true);
        tornadoArea.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, scaleTornado);
        tornadoDyingArea.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, scaleTornado);
        StartCoroutine(FinishGame());
    }

    IEnumerator FinishGame()
    {
        confetti.SetActive(true);
        yield return new WaitForSeconds(2f);

        EventManager.OnLevelChanged?.Invoke();
    }

}
