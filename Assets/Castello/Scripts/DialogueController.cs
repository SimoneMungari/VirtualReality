using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueController : MonoBehaviour
{
    [SerializeField] public Text textComponent;
    [SerializeField] private BoxDialogue boxDialogue;
    
    [SerializeField] private PlayerAction player;
    
    public string[] lines;
    public float textSpeed;
    
    
    private int index;
    void Start()
    {
        textComponent.text = string.Empty;
        textSpeed = 0.05f;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    private void Awake()
    {
        Messenger<string[]>.AddListener(GameEvent.DIALOGUE_STARTED, onDialogueStarted);
    }
    private void OnDestroy()
    {
        Messenger<string[]>.RemoveListener(GameEvent.DIALOGUE_STARTED, onDialogueStarted);
    }

    public void onDialogueStarted(string[] _lines)
    {
        lines = _lines;
        player.setDialogueStarted(true);
        boxDialogue.Open();
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            textComponent.text = string.Empty;
            player.setDialogueStarted(false);
            boxDialogue.Close();
        }
    }
}
