using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip boom;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void BoomBallonSound()
    {
        audioSource.PlayOneShot(boom);
    }
}
