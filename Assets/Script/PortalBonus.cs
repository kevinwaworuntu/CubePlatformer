using UnityEngine;

public class PortalBonus : MonoBehaviour
{
    public PlayerManager playerManager;
    [SerializeField] Transform player;
    [SerializeField] Transform targetPos;
    [SerializeField] CinemachineSwitcher camSwitcher;

 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerManager.isInteractable = true;
            playerManager.eventNumber = 1;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camSwitcher.vCam1.gameObject.SetActive(false);
            player.position = targetPos.position;
            camSwitcher.currentPost = 1;

        }
    }
}
