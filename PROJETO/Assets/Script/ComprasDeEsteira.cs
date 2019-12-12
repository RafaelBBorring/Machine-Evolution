using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ComprasDeEsteira : MonoBehaviour
{
    public int preco = 100;
    public Button comprarEsteira;
    public GameManager gameManager;

    void Update()
    {
        if (gameManager.money >= preco)
        {
            comprarEsteira.interactable= true;
        }
        else
        {
            comprarEsteira.interactable = false;
        }
    }

    public void ComprarEsteira()
    {
        gameManager.money -= preco;
        preco += preco;
    }
}
