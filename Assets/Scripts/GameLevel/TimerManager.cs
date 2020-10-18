using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [SerializeField]
    private Text sureText;

    int kalanSure;
    bool sureSaysinMi = true;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        kalanSure = 50;
        sureSaysinMi = true;
        
    }

    public void SureyiBaslat()
    {
        StartCoroutine(SureTimerRoutine());
    }

    IEnumerator SureTimerRoutine()
    {
        while (sureSaysinMi)
        {
            yield return new WaitForSeconds(2.5f);
            if (kalanSure < 10)
            {
                sureText.text = "0" + kalanSure.ToString();
            }
            else
            {
                yield return new WaitForSeconds(1f);
                sureText.text = kalanSure.ToString();
                //kalanSure--;
            }

            if (kalanSure <= 0)
            {
                sureSaysinMi = false;
                sureText.text = "";
                gameManager.OyunuBitir();


            }

            kalanSure--;
            
        }
    }
}
