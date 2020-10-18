using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{
    [SerializeField]
    private Text dogruAdetTxt, yanlisAdetTxt, puanText;

    int puanSuresi = 10;
    bool sureBittiMi = true;

    int toplamPuan, yazdirilacakPuan, artisPuani;

    private void Awake()
    {
        sureBittiMi = true;
    }

    public void SonuclariGoster(int dogruAdet, int yanlisAdet, int puan)
    {
        dogruAdetTxt.text = dogruAdet.ToString();
        yanlisAdetTxt.text = yanlisAdet.ToString();
        puanText.text = puan.ToString();

        toplamPuan = puan;
        artisPuani = toplamPuan / 10;

        StartCoroutine(PuaniYazdirRoutine());
    }
    IEnumerator PuaniYazdirRoutine()
    {
        while (sureBittiMi)
        {
            yield return new WaitForSeconds(0.1f);

            yazdirilacakPuan += artisPuani;

            if (yazdirilacakPuan >= toplamPuan)
            {
                yazdirilacakPuan = toplamPuan;
            }
            puanText.text = yazdirilacakPuan.ToString();

            if (puanSuresi <= 0)
            {
                sureBittiMi = false;
            }

            puanSuresi--;
        }
    }

    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
