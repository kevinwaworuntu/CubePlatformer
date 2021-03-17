using UnityEngine;

public class PortalExit : MonoBehaviour
{
    public PlayerManager playerManager;
    [SerializeField] Transform player;
    [SerializeField] Transform targetPos;
    [SerializeField] CinemachineSwitcher camSwitcher;


  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camSwitcher.vCam1.gameObject.SetActive(true);
            player.position = targetPos.position;
            camSwitcher.currentPost = 0;
            playerManager.isInteractable = false;
        }
    }
}
