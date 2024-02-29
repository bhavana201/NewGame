using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public float life = 1;
    public Rigidbody2D body;
    private void Awake()
    {
        Destroy(gameObject, life);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(gameObject);
        Destroy(collision.gameObject);
        GameObject.Find("Square").GetComponent<Score>().UpdateScore();
        /*if (collision.gameObject.TryGetComponent<EnemyScript>(out EnemyScript enemyscriptComponent))
        {

            enemyscriptComponent.takeDamage(1);
        }*/
        Destroy(gameObject);
    }
}
