using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    void Start()
    {
        Launch();
    }

    void Launch()
    {
        bool isRight = UnityEngine.Random.value > 0.5f;
        float xVelocity = -1f;
        if (isRight == true)
        {
            xVelocity = 1f;
        }
        float yVelocity = UnityEngine.Random.Range(-1f, 1f);
        rb.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;
        transform.position = Vector3.zero;
        Invoke("Launch", 1f);
    }

    void Update()
    {
    }
}