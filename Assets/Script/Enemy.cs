using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected AudioManager audioManager;
    [SerializeField] protected float movementSpeed;
    [SerializeField] protected float distance;
    protected int damage;

    public void Movement()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
    }
}
