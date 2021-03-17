using UnityEngine;

public class EnemyOrange : Enemy
{ 
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
    
}
