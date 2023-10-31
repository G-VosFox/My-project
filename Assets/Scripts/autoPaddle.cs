using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class autoPaddle : MonoBehaviour
{
    public float yPosition = 0f;
    public float yPace = 3f;
    public float heightLimit = 3.8f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(8f, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (yPosition >= heightLimit || yPosition <= -heightLimit)
        {
            yPace *= -1f;
        }
        yPosition += yPace * Time.deltaTime;

        transform.position = new Vector3(8f, yPosition, 0f);
    }
}
