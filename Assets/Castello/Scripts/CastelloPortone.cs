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
        Debug.Log("aaaa");
        if (SceneManager.GetActiveScene().name == "scena")
        {
            SceneManager.LoadScene("Scenes/Castello");
        }
        else if (SceneManager.GetActiveScene().name == "Castello")
        {
            SceneManager.LoadScene("Scenes/scena");
        }
        
    }
}
