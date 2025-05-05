using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    public int maxHealth, gecerliSaglik;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        gecerliSaglik = maxHealth;
        UIManager.Instance.SliderGuncelle(gecerliSaglik,maxHealth);
    }

    public void CaniAzaltFNC()
    {
        gecerliSaglik--;
        UIManager.Instance.SliderGuncelle(gecerliSaglik, maxHealth);
        if (gecerliSaglik<=0)
            {
            gecerliSaglik=0;
            //gameObject.SetActive(false);
            PlayerHareketController.instance.PlayerCanVerdiFNC();

        }
    }
}
