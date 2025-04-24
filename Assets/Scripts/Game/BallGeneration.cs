using UnityEngine;

public class BallGeneration : MonoBehaviour
{
    [SerializeField] private Sprite[] spritesColors;

    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int quantity = spritesColors.Length;
        int color = Random.Range(0, quantity);
        spriteRenderer.sprite = spritesColors[color];
    }
}
