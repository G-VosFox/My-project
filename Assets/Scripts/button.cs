using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void single() 
    {
        SceneManager.LoadScene("singlePlayer");
    }
    public void two() 
    { 
        SceneManager.LoadScene("score");
    }
    public void funk() 
    {
        SceneManager.LoadScene("exit");
    }  
}
