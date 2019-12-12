using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EsteiraButtons : MonoBehaviour
{
    Esteira esteira;
    public Button upgradeButton;
    public Button produceBT;
    private GameManager gameManager;
    //
    private int custoUp;
    private bool produzindo;
    private float timeProducing;
    public int timeToProduce;
    public TextMeshProUGUI timeText;
    public GameObject timeTextGO;
    //
    public MeshFilter meshFilter;

    public Mesh[] esteiraOBJ;

    public int esteiraMesh;

    void Start()
    {
        gameManager = GameManager.instance;
        esteira = GetComponentInParent<Esteira>();
        custoUp = 100;
    }
    void Update()
    {
        timeText.text = timeProducing.ToString("F0");

        if (timeProducing <= 0)
        {
            timeTextGO.SetActive(false);
        }
        else
        {
            timeTextGO.SetActive(true);
        }

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
                gameManager.money += 10 * esteira.esteiraLv;
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

        if (esteira.esteiraLv < 5)
        {
            esteiraMesh = 0;
            meshFilter.mesh = esteiraOBJ[esteiraMesh];
        }
        else
        {
            if (esteira.esteiraLv < 10)
            {
                esteiraMesh = 1;
                meshFilter.mesh = esteiraOBJ[esteiraMesh];
            }
            else
            {
                if (esteira.esteiraLv < 15)
                {
                    esteiraMesh = 2;
                    meshFilter.mesh = esteiraOBJ[esteiraMesh];
                }
                else
                {
                    if (esteira.esteiraLv < 25)
                    {
                        esteiraMesh = 3;
                        meshFilter.mesh = esteiraOBJ[esteiraMesh];
                    }
                    else
                    {

                    }
                }
            }
        }


    }

    public void Product()
    {
        produceBT.interactable = false;
        timeProducing = timeToProduce;
        produzindo = true;
    }
}
