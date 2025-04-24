using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text[] pointText;
    [SerializeField] private string positionSave;
    private int currentRecord;
    void Start()
    {
        foreach(Text text in pointText)
        {
            text.text = "0";   
        }
        if (PlayerPrefs.GetString(positionSave) != "")
        {
            currentRecord = int.Parse(PlayerPrefs.GetString(positionSave));
        }
        else
        {
            currentRecord = 0;
        }
    }

    public void AddPoint(int pnt)
    {
        int score = int.Parse(pointText[0].text);
        score += pnt;
        pointText[0].text = score.ToString();
        pointText[1].text = pointText[0].text;
        BestRecordSave();
    }

    public void BestRecordSave()
    {
        int score = int.Parse(pointText[0].text);
        if(score > currentRecord)
        {
            PlayerPrefs.SetString(positionSave, score.ToString());
            currentRecord = score;
        }
        
    }

    public string ReturnScore()
    {
        return pointText[0].text;
    }


}
