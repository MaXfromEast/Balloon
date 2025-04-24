using UnityEngine;

public class BallDeather : MonoBehaviour
{
    private LifeLooser lifeLooser;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathLine")
        {
            lifeLooser.MinusLife();
            Destroy(gameObject);
        }
        if (collision.tag == "DeathLine2")
        {
            Destroy(gameObject);
        }
    }

    public void SetLifeLooser(LifeLooser l)
    {
        lifeLooser = l;
    }
}
