using UnityEngine;
using UnityEngine.UI;

public class LifeLooser : MonoBehaviour
{
    private int life;
    [SerializeField] private Image[] imagesHearts;
    [SerializeField] private Sprite fullHearts;
    [SerializeField] private Sprite emptyHearts;
    [SerializeField] private Pause pause;
    [SerializeField] private GameObject windowEnd;

    private void Start()
    {
        foreach (Image image in imagesHearts)
        {
            image.sprite = fullHearts;
        }
        life = 3;
    }

    public void MinusLife()
    {
        life--;
        WriteWhiteHearts();
        if(life == 0)
        {
            pause.PauseOn();
            windowEnd.SetActive(true);
        }
    }

    private void WriteWhiteHearts()
    {
        for(int i = 3; i > life; i--)
        {
            imagesHearts[i-1].sprite = emptyHearts;
        }
    }
}
