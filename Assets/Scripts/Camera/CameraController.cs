using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    PlayerHareketController player;
   public  Collider2D boundsBox;
    float halfYükseklik, halfGeniþlik;

    Vector2 sonPos;
    [SerializeField]
    Transform backgrounds;

    private void Awake()
    {
        player =Object.FindAnyObjectByType<PlayerHareketController>();
    }
    private void Start()
    {
        halfYükseklik = Camera.main.orthographicSize;
        halfGeniþlik = halfYükseklik * Camera.main.aspect;
        sonPos = transform.position;
    }

    private void Update()
    {
        if (player != null)
        {
            transform.position =new Vector3( 
               Mathf.Clamp( player.transform.position.x,boundsBox.bounds.min.x+ halfGeniþlik,boundsBox.bounds.max.x-halfGeniþlik),
                Mathf.Clamp(player.transform.position.y,boundsBox.bounds.min.y+halfYükseklik,boundsBox.bounds.max.y-halfYükseklik),
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
