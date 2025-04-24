using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsMaker : MonoBehaviour
{
    [SerializeField] private GameObject balloon;
    [SerializeField] private int quantityBalloon;
    [SerializeField] private int quantityPositions;
    [SerializeField] private float distanceBetweenBalls;
    private float[] positionsXBalls;
    [SerializeField] private float positionYBall;
    private List<GameObject> listBalloons;
    private int countBalloon;
    private Sound sound;
    [SerializeField] private Score score;
    [SerializeField] private LifeLooser lifeLooser;
    private Pause pause;
    [SerializeField] private float timerReloadBallone;

    private void Start()
    {
        pause = GetComponent<Pause>();
        pause.PauseOff();
        sound = GetComponent<Sound>();
        LoadBalloon();
    }

    private void LoadBalloon()
    {
        countBalloon = 0;
        listBalloons = new List<GameObject>();
        positionsXBalls = new float[quantityPositions];
        float positionStart = -2f;
        for (int i = 0; i < quantityPositions; i++)
        {
            positionsXBalls[i] = positionStart;
            positionStart = positionStart + distanceBetweenBalls;
        }

        for (int i = 0; i < quantityBalloon; i++)
        {
            int r = Random.Range(0, 9);
            Vector2 positionBallons = new Vector2(positionsXBalls[r], positionYBall);
            GameObject ball = Instantiate(balloon, positionBallons, Quaternion.identity);
            ball.GetComponent<Shooter>().SetSound(sound);
            ball.GetComponent<Shooter>().SetCounter(score);
            ball.GetComponent<BallDeather>().SetLifeLooser(lifeLooser);
            listBalloons.Add(ball);
        }
        StartCoroutine(BalloonStarter());
    }

    private IEnumerator BalloonStarter()
    {
        yield return new WaitForSeconds(timerReloadBallone);
        listBalloons[countBalloon].GetComponent<BallsFlyer>().IsFly();
        countBalloon++;
        if(countBalloon < quantityBalloon)
        {
            StartCoroutine(BalloonStarter());
        }
        else
        {
            LoadBalloon();
            if (timerReloadBallone > 0.15f)
            {
                timerReloadBallone = timerReloadBallone - 0.1f;
            }
        }

    }
}
