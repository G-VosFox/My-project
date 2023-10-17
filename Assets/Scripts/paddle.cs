using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class paddle : MonoBehaviour
{
    public float speed = 5f;
    public float heightLimit = 3.8f;
    public string leftOrRight;
    public bool newBall = false;
    public int ballAmount = 1;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;

    void Start()
    {
        ball1.SetActive(true);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
    }
    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < heightLimit)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -heightLimit)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("ball") && newBall == true && ballAmount == 1)
        {
            ballAmount++;
            ball2.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("ball") && newBall == true && ballAmount == 2)
        {
            ballAmount++;
            ball3.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("ball") && newBall == true && ballAmount == 3)
        {
            ballAmount++;
            ball4.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("ball") && newBall == true && ballAmount == 4)
        {
            ballAmount++;
            ball5.SetActive(true);
        }
    }
}
