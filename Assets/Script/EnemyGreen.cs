using UnityEngine;

public class EnemyGreen : Enemy
{
    [SerializeField] PlayerManager player;
    [SerializeField] private Vector2 maxHeight;
    [SerializeField] private Transform playerCheck;
    private Vector2 startPos;
    private void Start()
    {
        startPos.y = this.gameObject.transform.position.y;
    }

    //Movement in Update because it's not using Rigidbody
    private void Update()
    {

        RaycastHit2D objectInfo = Physics2D.Raycast(playerCheck.position, Vector2.up, distance);
        if (objectInfo.collider == true)
        {

            if (gameObject.transform.position.y <= maxHeight.y)
            {
                Jump(1f);
            }   
        }
        else
        {
            if(gameObject.transform.position.y >= startPos.y)
            {
                Jump(-1f);
                //transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
            }
        }
    }
    void Jump(float condition)
    {
        transform.Translate(0, movementSpeed * Time.deltaTime * condition, 0);
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
