using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public Text MoneyText;
    public int money = 0;
    public int machineLevel = 1;
    public int playerLevel = 1;
    public int pedidosProntos = 0;
    public int numeroPedidos = 0;
    public float contasTime;
    public int contas = 0;
    public int taxa;

    public bool isPaused;
    public GameObject pausePainel;
    public Animator pausedAnim;

    public float time = 0;

    public List<Esteira> esteiras;

    public static GameManager instance;


    public int qtdEsteiras;

    void Awake()
    {
        instance = this;

        taxa = playerLevel * money;
        contas = taxa - (playerLevel * 5);

    }

    void Start()
    {
        
        InvokeRepeating("CobrarContas2", contasTime , contasTime);
    }


    void Update()
    {
        if(pausedAnim != null)
            pausedAnim.SetBool("isPaused",isPaused);

        MoneyText.text = money.ToString();

        taxa = playerLevel * money / 10;
        contas = (money / 5) * (taxa / 5) + 5;


    }


    void CobrarContas()
    {
        money -= contas;
    }

    public void HideAllPanels()
    {
        foreach (Esteira e in esteiras)
        {

            e.closePainel();
        }
    }

    //public Sprite pausebtnSprite;
   // public Sprite playerbtnSprite;
   // public GameManager pauseButton;

    public void PauseGame()
    {
        isPaused = !isPaused;
        if (pausedAnim != null)
            pausedAnim.SetBool("IsPaused", isPaused);
        if (isPaused)
        {
           // pauseButton.GetComponent<Image>().sprite = pausebtnSprite;
           if(pausePainel != null )
                pausePainel.SetActive(true);
                Time.timeScale = 0;
        }
        else
        {
            if (pausePainel != null)
                pausePainel.SetActive(false);
                Time.timeScale = 1;
        }
        
    }

    public void TakeMoney(int quantidade)
    { 
        money -= quantidade;
    }

    public void BuyEsteira()
    {
        if(qtdEsteiras < esteiras.Count && money >= esteiras[qtdEsteiras].preco)
        {
            qtdEsteiras++;
            for (int i = 0; i < qtdEsteiras; i++)
            {
                esteiras[i].gameObject.SetActive(true);
                if (!esteiras[i].comprada)
                {
                    TakeMoney(esteiras[i].preco);
                    esteiras[i].comprada = true;
                  
                }
            }
        }
      

    }


}
