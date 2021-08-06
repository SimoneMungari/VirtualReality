using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDialogue : MonoBehaviour
{
    [SerializeField] public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Open()
    {
        gameObject.SetActive(true);
        this.PausePlayer();
    }
    public void Close()
    { 
        gameObject.SetActive(false);
        this.UnPausePlayer();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PausePlayer()
    {
        /*GameEvent.isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;*/
        player.GetComponent<RelativeMovement>().enabled = false;
    }
    public void UnPausePlayer()
    {
        /*GameEvent.isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;*/
        player.GetComponent<RelativeMovement>().enabled = true;
    }
}