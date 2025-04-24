using UnityEngine;
using UnityEngine.UI;

public class TimerLooser : MonoBehaviour
{
    [SerializeField] private Pause pause;
    [SerializeField] private GameObject windowEnd;
    [SerializeField] private float timeForGame;
    [SerializeField] private Image imgVioletButton;
    private float currentTime;

    private void Start()
    {
        currentTime = timeForGame;
        imgVioletButton.fillAmount = 1;
    }
    //private IEnumerator TimerLive()
    //{
    //    yield return new WaitForSeconds(60f);
    //    pause.PauseOn();
    //    windowEnd.SetActive(true);
    //}

    private void Update()
    {
        currentTime -= Time.deltaTime;
        imgVioletButton.fillAmount = currentTime / timeForGame;
        if(currentTime<=0)
        {
            pause.PauseOn();
            windowEnd.SetActive(true);
        }
    }
}
