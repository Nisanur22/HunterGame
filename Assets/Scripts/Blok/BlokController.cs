using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokController : MonoBehaviour
{
    public Transform altPoint;
    Animator anim;
     Vector3 hareketYonu = Vector3.up;
     Vector3 orijinalPos;
     Vector3 animPos;
     public LayerMask playerLayer;

    bool animasyonBaslasinmi;
    bool hareketEtsinmi = true;

    public GameObject coinPrefab;
    Vector3 coinPos;
    private void Awake()
    {
            anim = GetComponent<Animator>();
    }
    private   void Start()
    {
        orijinalPos = transform.position;
        animPos = transform.position;
        animPos.y += 0.15f;

        coinPos = transform.position;
        coinPos.y += 1f;
    }

   
    private  void Update()
    {
        CarpismayiKontrolEt();
        AnimasyonuBaslat();
    }
    void CarpismayiKontrolEt()
    {
        if (hareketEtsinmi)
        {
            RaycastHit2D hit = Physics2D.Raycast(altPoint.position, Vector2.down, .1f, playerLayer);

            if (hit && hit.collider.gameObject.tag == "Player")
            {
                anim.Play("mat");
                animasyonBaslasinmi = true;
                hareketEtsinmi=false;

                Instantiate(coinPrefab,coinPos,Quaternion.identity);
            }
        }
    }
    void AnimasyonuBaslat()
    {
        if (animasyonBaslasinmi)
        {
            transform.Translate(hareketYonu * Time.smoothDeltaTime);

            if (transform.position.y >= animPos.y)
            {
                hareketYonu = Vector3.down;
            }
            else if (transform.position.y <= orijinalPos.y)
            {
                animasyonBaslasinmi = false;

            }
        }

    }
}
   

