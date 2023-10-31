using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class goals : MonoBehaviour
{
    public TMP_Text score;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 10;
    public string leftOrRight;
    public bool newBall = false;
    public int ballAmount = 1;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;

    // Start is called before the first frame update
    void Start()
    {
        ball1.SetActive(true);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (leftScore >= winScore)
        {
            score.text = "Left wins";
        }
        if (rightScore >= winScore)
        {
            score.text = "Right wins";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball") && leftOrRight == "left")
        {
            rightScore++;
            score.text = "" + rightScore;
        }
        else if (collision.gameObject.CompareTag("ball") && leftOrRight == "right")
        {
            leftScore++;
            score.text = leftScore + "";
        }
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
