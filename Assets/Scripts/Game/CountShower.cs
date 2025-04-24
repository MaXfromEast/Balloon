using UnityEngine;
using UnityEngine.UI;

public class CountShower : MonoBehaviour
{
    [SerializeField] private string positionSave;
    [SerializeField] private Text textCurret;
    [SerializeField] private Text textRecord;
    [SerializeField] private Score score;
    private void Start()
    {
        if (PlayerPrefs.GetString(positionSave) != "")
        {
            textRecord.text = PlayerPrefs.GetString(positionSave);
        }
        textCurret.text = score.ReturnScore();
    }
}
