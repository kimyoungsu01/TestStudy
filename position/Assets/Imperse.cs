using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public GameObject Object;
   private Rigidbody rg;

    private void Awake()
    {
        rg = GetComponent<Rigidbody>();
    }

    public void Imperse() 
    {
        rg.AddForce(Vector3.up * 3f, ForceMode.Impulse);
    }
}
