using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EsteiraButtons : MonoBehaviour
{
    Esteira esteira;
    public Button upgradeButton;
    private GameManager gameManager;
    //
    private int custoUp;

    void Start()
    {
        gameManager = GameManager.instance;
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

        gameManager.money += 10;

    }
}
