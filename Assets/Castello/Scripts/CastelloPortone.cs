using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastelloPortone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void React()
    {
        if (SceneManager.GetActiveScene().name == "BrightDay")
        {
            SceneManager.LoadScene("Castello/Scenes/Castello");
        }
        else if (SceneManager.GetActiveScene().name == "Castello")
        {
            SceneManager.LoadScene("Foresta/Scenes/BrightDay");
        }
        
    }
}
