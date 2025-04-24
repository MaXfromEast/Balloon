using UnityEngine;
using UnityEngine.UI;

public class SoundTuner : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource sound;
    [SerializeField] private OnOffButton onOffMsc;
    [SerializeField] private OnOffButton onOffSnd;
    
    private void Start()
    {
        if (PlayerPrefs.GetString("Music") == "Off")
        {
            onOffMsc.SwitchOff();
            music.mute = true;
        }
        else
        {
            onOffMsc.SwitchOn();
            music.mute = false;
        }

        if (PlayerPrefs.GetString("Sound") == "Off")
        {
            onOffSnd.SwitchOff();
        }
        else
        {
            onOffSnd.SwitchOn();
        }
    }
    public void SoundOnOff()
    {
        
        if (PlayerPrefs.GetString("Sound") != "Off")
        {
            PlayerPrefs.SetString("Sound", "Off");
            onOffSnd.SwitchOff();
            sound.mute = true;
        }
        else
        {
            PlayerPrefs.SetString("Sound", "On");
            onOffSnd.SwitchOn();
            sound.mute = false;
        }
    }

    public void MusicOnOff()
    {
        if (PlayerPrefs.GetString("Music") != "Off")
        {
            PlayerPrefs.SetString("Music", "Off");
            onOffMsc.SwitchOff();
            music.mute = true;
        }
        else
        {
            PlayerPrefs.SetString("Music", "On");
            onOffMsc.SwitchOn();
            music.mute = false;
        }
    }
}
