using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GeriSayimManager : MonoBehaviour
{
    [SerializeField]
    private GameObject geriSayimObje;

    [SerializeField]
    private Text geriSayimText;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();

    }
    void Start()
    {
        StartCoroutine(GeriyeSarRoutine());
    }

    IEnumerator GeriyeSarRoutine()
    {
        geriSayimText.text = "3";
        yield return new WaitForSeconds(0.5f);

        geriSayimObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        geriSayimText.text = "2";

        yield return new WaitForSeconds(0.5f);

        geriSayimObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        geriSayimText.text = "1";

        geriSayimObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        StopAllCoroutines();

        gameManager.OyunaBasla();


    }
    
}
