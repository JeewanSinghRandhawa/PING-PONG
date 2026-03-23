using UnityEngine;

public class P1 : MonoBehaviour
{
    public float movespeed;
    public float topLimit = 4.5f;
    public float bottomLimit = -4.5f;

    void Start()
    {
    }

    void Update()
    {
        bool isPressingup = Input.GetKey(KeyCode.W);
        bool isPressingdown = Input.GetKey(KeyCode.S);

        if (isPressingup && transform.position.y < topLimit)
        {
            transform.Translate(Vector2.up * Time.deltaTime * movespeed);
        }
        if (isPressingdown && transform.position.y > bottomLimit)
        {
            transform.Translate(Vector2.down * Time.deltaTime * movespeed);
        }
    }
}