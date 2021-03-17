using UnityEngine;

public class BonusArena : MonoBehaviour
{
    [SerializeField] GameObject platformBonus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            platformBonus.SetActive(true);
        }
    }
}
