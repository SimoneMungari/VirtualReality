using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class QuestManager : MonoBehaviour, IGameManager
    {
        public ManagerStatus status {get; private set;}

        public void Startup(){
            Debug.Log("Quest manager starting...");
            status = ManagerStatus.Started;
        }
        void Start()
        {

        }
 
        // Update is called once per frame
        void Update()
        {

        }
    }