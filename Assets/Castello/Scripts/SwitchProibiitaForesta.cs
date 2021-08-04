using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchProibiitaForesta : MonoBehaviour
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
    {Debug.Log("cambiah");
        if (SceneManager.GetActiveScene().name == "BrightDay")
        {
            SceneManager.LoadScene("Zona Proibita/Scenes/ZonaProibita");
        }
        else if (SceneManager.GetActiveScene().name == "ZonaProibita")
        {
            SceneManager.LoadScene("Foresta/Scenes/BrightDay");
        }
        
    }
}
