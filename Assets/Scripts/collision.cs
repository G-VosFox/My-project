using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class collision : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xPace = 3f;
    public float yPace = 3f;
    public bool goal = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition += xPace * Time.deltaTime;
        yPosition += yPace * Time.deltaTime;

        if (goal == true)
        {
            xPosition = 0f;
            yPosition = 0f;
            xPace *= -1f;
            goal = false;
        }

        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            yPace *= -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xPace *= -1f;
        }
        if (collision.gameObject.CompareTag("goalL"))
        {
            goal = true;
        }
        else if (collision.gameObject.CompareTag("goalR"))
        {
            goal = true;
        }
    }
}
