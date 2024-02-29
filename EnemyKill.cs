using UnityEngine;
using UnityEngine.UI;

public class EnemyKill : MonoBehaviour
{
    public GameObject enemy;
    public float moveRate = 2;
    private float timer = 0;
    public Text MyScore;
    public int ScoreNum;



    // Start is called before the first frame update
    void Start()
    {
        spawnMove();
        ScoreNum = 0;
        // MyScore.text = "score" + ScoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < moveRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnMove();
            timer = 0;
        }

    }
    void spawnMove()
    {
        float lp = transform.position.x - 1;
        //float hp = transform.position.x + 1;
        Instantiate(enemy, new Vector3(Random.Range(0, lp), transform.position.y, 0), transform.rotation);
    }

}

