using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public static UIManager Instance;
    [SerializeField]
    Slider playerSlider;
    [SerializeField]
    TMP_Text coinTxt;

    private void Awake()
    {
        Instance = this;
    }

    public void SliderGuncelle(int gecerliDeger, int maxDeger)
    {
        playerSlider.maxValue = maxDeger;
        playerSlider.value = gecerliDeger;
    }
    public void CoinAdetGuncelle()
    {
        coinTxt.text = GameManager.Instance.toplananCoinAdet.ToString();
    }

}
