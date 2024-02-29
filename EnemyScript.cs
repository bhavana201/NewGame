using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //public float health, maxHealth;
    //public GameObject tri;
    public float mSpeed = 5;
    public float deadZone = -15;


    public void Start()
    {
        //health = maxHealth;


    }
    [ContextMenu("IncreaseScore")]
    public void Update()
    {
        transform.position = transform.position + (Vector3.left * mSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    /* public void takeDamage(float damageAmount)
     {
         health -= damageAmount;
         if (health <= 0)
         {
             Debug.Log(gameObject.name);
             Destroy(tri);

         }
     }*/


}
