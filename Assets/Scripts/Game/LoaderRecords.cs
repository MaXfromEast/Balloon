using UnityEngine;
using UnityEngine.UI;

public class LoaderRecords : MonoBehaviour
{
    [SerializeField] private Text textRecordStd;
    [SerializeField] private Text textRecordTimer;
    [SerializeField] private Text textRecordInfinity;


    private void Start()
    {
        if(PlayerPrefs.GetString("ScoreStd") != "")
        {
            textRecordStd.text = PlayerPrefs.GetString("ScoreStd");
        }
        if (PlayerPrefs.GetString("ScoreTimer") != "")
        {
            textRecordTimer.text = PlayerPrefs.GetString("ScoreTimer");
        }
        if(PlayerPrefs.GetString("ScoreInf") != "")
        {
            textRecordInfinity.text = PlayerPrefs.GetString("ScoreInf");
        }
        
    }
}
