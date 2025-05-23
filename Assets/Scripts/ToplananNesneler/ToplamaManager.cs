using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplamaManager : MonoBehaviour
{
    [SerializeField]
    bool coinmi;
    [SerializeField]
    GameObject coinEfekt;

    bool toplandimi;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !toplandimi)
            {
            toplandimi = true;
            GameManager.Instance.toplananCoinAdet++;
            UIManager.Instance.CoinAdetGuncelle();
            Destroy(gameObject);
            Instantiate(coinEfekt,transform.position,Quaternion.identity);
        }
    } }
