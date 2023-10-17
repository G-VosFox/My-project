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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftScore >= 10)
        {
            score.text = "Left wins";
        }
        if (rightScore >= 10)
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
    }
}
