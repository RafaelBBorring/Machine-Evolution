using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_ : MonoBehaviour
{
    public GameObject painelCompras;
    public bool painelcBool;

    private void Update()
    {
        painelCompras.SetActive(painelcBool);
    }
    public void OpenPainel()
    {
        painelcBool =! painelcBool;
    }
}
