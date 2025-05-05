using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int toplananCoinAdet;
    private void Awake()
    {
        Instance = this;
    }
    public void Start()
    {
         toplananCoinAdet = 0;
    }

}
