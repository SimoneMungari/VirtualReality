using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class Person : MonoBehaviour
{
    public string[] lines;

    public int id;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadLines();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogue()
    {
        Messenger<string[]>.Broadcast(GameEvent.DIALOGUE_STARTED, lines);
    }

    private void LoadLines()
    {
        string textFile = "Assets/Castello/Dialogues/" + id + ".txt";
        if (File.Exists(textFile)) {
            lines = File.ReadAllLines(textFile);
        }
        else
        {
            lines = new string[] {""};
        } 
    }
}
