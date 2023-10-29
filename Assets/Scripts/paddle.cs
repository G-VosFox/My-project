using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class paddle : MonoBehaviour
{
    public float speed = 5f;
    public float heightLimit = 3.8f;
    public string leftOrRight;

    void Start()
    {

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
}
