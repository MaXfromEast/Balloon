using System;
using UnityEngine;
using UnityEngine.UI;

public class OnOffButton : MonoBehaviour
{
    [SerializeField] private Sprite on;
    [SerializeField] private Sprite off;
    private Image current;
    private Action action;

    public void SwitchOnOff()
    {
        action.Invoke();
    }

    public void SwitchOn()
    {
        current = GetComponent<Image>();
        current.sprite = on;
        action = SwitchOff;
    }
    public void SwitchOff()
    {
        current = GetComponent<Image>();
        current.sprite = off;
        action = SwitchOn;
    }

}
