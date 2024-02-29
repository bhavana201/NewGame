using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D body;
    public GameObject ballprefab;
    public Transform fballshoot;
    public Camera cam;
    void Start()
    {
        cam = Camera.main;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            body.velocity = Vector2.left * 2;

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            body.velocity = Vector2.left * 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            body.velocity = Vector2.right * 2;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            body.velocity = Vector2.right * 0;
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            var b = Instantiate(ballprefab, fballshoot);
            b.GetComponent<Rigidbody2D>().velocity = fballshoot.up * moveSpeed;

        }

    }

}
