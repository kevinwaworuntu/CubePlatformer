using UnityEngine;

public class EnemyPurple : Enemy
{
    [SerializeField] private PlayerManager player;
    [SerializeField] private Transform groundCheck;
    private bool facingRight = true;

    //Movement in Update because it's not using Rigidbody
    void Update()
    {
        Movement();
        RaycastHit2D objectInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);
        if (objectInfo.collider == false)
        {
            if (facingRight == true) {
                transform.eulerAngles = new Vector2(0,-180);
                facingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector2(0,0);
                facingRight = true;
            }
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && player.invisiblilty == false)
        {
            damage = 1;
            player.health -= damage;
            player.invisiblilty = true;
            audioManager.EnemySFX();
        }
    }
}
