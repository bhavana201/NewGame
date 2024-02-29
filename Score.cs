using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScore;
    //public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreNum = 0;
        // MyScore.text = "score" + ScoreNum;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore()
    {
        int count = int.Parse(MyScore.text);
        MyScore.text = (count + 1).ToString();
    }
}
