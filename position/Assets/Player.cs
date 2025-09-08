using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public PlayerController Controller;

    private void Awake()
    {
        ChacterManager.Instance._player = this;
        Debug.Log(Controller);
        Controller = GetComponent<PlayerController>();
    }
}
