using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    PlayerHareketController player;
   public  Collider2D boundsBox;
    float halfY�kseklik, halfGeni�lik;

    Vector2 sonPos;
    [SerializeField]
    Transform backgrounds;

    private void Awake()
    {
        player =Object.FindAnyObjectByType<PlayerHareketController>();
    }
    private void Start()
    {
        halfY�kseklik = Camera.main.orthographicSize;
        halfGeni�lik = halfY�kseklik * Camera.main.aspect;
        sonPos = transform.position;
    }

    private void Update()
    {
        if (player != null)
        {
            transform.position =new Vector3( 
               Mathf.Clamp( player.transform.position.x,boundsBox.bounds.min.x+ halfGeni�lik,boundsBox.bounds.max.x-halfGeni�lik),
                Mathf.Clamp(player.transform.position.y,boundsBox.bounds.min.y+halfY�kseklik,boundsBox.bounds.max.y-halfY�kseklik),
                transform.position.z);
        }

        BackgroundHareketFNC();

    }

    void BackgroundHareketFNC()
    {
        Vector2 aradakifark = new Vector2(transform.position.x-sonPos.x,transform.position.y-sonPos.y);

        backgrounds.position += new Vector3(aradakifark.x, aradakifark.y, 0f);
        sonPos = transform.position;
    }
}
