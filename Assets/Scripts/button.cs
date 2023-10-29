using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public button normButton;
    public button funkButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnGUI();
    }
    void OnGUI()
    {
        if (normButton)
        {
            SceneManager.LoadScene("score");
        }

        else if (funkButton)
        {
            SceneManager.LoadScene("exit");
        }
    }
}
