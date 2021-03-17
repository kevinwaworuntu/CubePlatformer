using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public int health;
    private int startHealth = 3;
    public bool invisiblilty;
    [SerializeField] private float invisTime;

    public int coinCollected;
    public int multiply;

    public bool isInteractable;
    public int eventNumber;
    public UnityEvent event1;

   
    void Start()
    {
        health = startHealth;
    }

    void Update()
    {
        CoinCounter(multiply);
        
        if(invisiblilty == true)
        {
            StartCoroutine(EnemyHit());
        }
        else
        {

        }
    }
    void CoinCounter(int multiplier)
    {
        coinCollected *= multiplier;
    }

    IEnumerator EnemyHit()
    {
        yield return new WaitForSeconds(invisTime);
        invisiblilty = false;
    }
   
}
