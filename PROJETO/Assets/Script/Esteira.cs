using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esteira : MonoBehaviour
{
    //OpenPainel Variaveis
    public GameObject esteiraPainel;
    public int esteiraLv;
    public int preco;
    public bool comprada;

    void Start()
    {

        esteiraPainel.SetActive(false);
    }

    public void closePainel()
    {
        esteiraPainel.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (Mov_Camera.Mov != true)
        {
            GameManager.instance.HideAllPanels();
            esteiraPainel.SetActive(true);
        }
    }


}
