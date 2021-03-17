using UnityEngine;

public class HitManager : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] GameManager gm;
    [SerializeField] AudioManager audioManager;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Coin":
                playerManager.coinCollected++;
                audioManager.CoinSFX();
                Destroy(collision.gameObject);
                return;
            case "Finish":
                gm.isFinish = true;
                return;
            case "Fall":
                gm.GameOver();
                return;
        }

    }
}
