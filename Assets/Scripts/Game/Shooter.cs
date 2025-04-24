using UnityEngine;
using UnityEngine.EventSystems;

public class Shooter : MonoBehaviour, IPointerClickHandler
{
    private Sound sound;
    private Score score;
    public void OnPointerClick(PointerEventData eventData)
    {
        sound.BoomBallonSound();
        score.AddPoint(1);
        Destroy(gameObject, 0.1f);
    }

    public void SetSound(Sound s)
    {
        sound = s;
    }
    public void SetCounter(Score s)
    {
        score = s;
    }


}
