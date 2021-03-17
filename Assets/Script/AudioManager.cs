using UnityEngine.Events;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioClip coinClip, uIClip, jumpClip, enemyClip;

    public void CoinSFX()
    {
        audioSource.PlayOneShot(coinClip);
    }
    public void UISFX()
    {
        audioSource.PlayOneShot(uIClip);
    }
    public void jumpSFX()
    {
        audioSource.PlayOneShot(jumpClip);
    }
    public void EnemySFX()
    {
        audioSource.PlayOneShot(enemyClip);
    }

}
