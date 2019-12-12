using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EsteiraButtons : MonoBehaviour
{
    Esteira esteira;
    public Button upgradeButton;
    public Button produceBT;
    public GameManager gameManager;
    //
    private int custoUp;
    private bool produzindo;
    private float timeProducing;
    public int timeToProduce;

    void Start()
    {       
        esteira = GetComponentInParent<Esteira>();
        custoUp = 100;
    }
    void Update()
    {
        if (gameManager.money >= custoUp)
        {
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeButton.interactable = false;
        }

        if (produzindo == true)
        {

            if (timeProducing <= 0)
            {
                produceBT.interactable = true;
                gameManager.money += 10;
                produzindo = false;
            }
            else
            {
                
                timeProducing -= Time.deltaTime;
            }
        }
    }


    public void closeEsteiraPainel()
    {
        esteira.closePainel();
    }

    public void UpEsteira()
    {
        gameManager.money -= custoUp;
        esteira.esteiraLv += 1;

        custoUp += 60;
    }

    public void Product()
    {
        produceBT.interactable = false;
        timeProducing = timeToProduce;
        produzindo = true;
    }
}
