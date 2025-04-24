using UnityEngine;

public class BallsFlyer : MonoBehaviour
{
    private Vector2 direction;
    private bool isFly;
    private Collider2D c2D;
    private void Start()
    {
        c2D = GetComponent<Collider2D>();
        c2D.enabled = false;
        isFly = false;
        int speed = Random.Range(1, 5);
        direction = new Vector2(0, speed);
    }
    private void Update()
    {
        if(isFly)
        {
            transform.Translate(direction * Time.deltaTime);
        }
        
    }
    public void IsFly()
    {
        isFly = true;
        c2D.enabled = true;
    }
}
