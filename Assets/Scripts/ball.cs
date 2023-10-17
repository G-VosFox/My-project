using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xPace = 1f;
    public float yPace = 1f;

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

        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
}
