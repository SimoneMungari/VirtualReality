using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(QuestManager))]
public class Managers : MonoBehaviour
{
    
    public static QuestManager quest {get; private set;}

    private List<IGameManager> _startSequence;

    void Awake() //Viene chiamato prima degli start
    {
        quest = GetComponent<QuestManager>();

        _startSequence = new List<IGameManager>();
        _startSequence.Add(quest);

        StartCoroutine(StartupManagers());
    }

    private IEnumerator StartupManagers()
    {
        foreach (IGameManager manager in _startSequence)
        {
            manager.Startup();
        }

        yield return null;

        int numModules = _startSequence.Count;
        int numReady = 0;

        while (numReady < numModules)
        {
            int lastReady = numReady;
            numReady = 0;
            foreach (IGameManager manager in _startSequence)
            {
                if (manager.status == ManagerStatus.Started)
                {
                    numReady++;
                }
            }
            if (numReady > lastReady)
            {
                Debug.Log ("Progress: " + numReady + "/" + numModules);
            }
            yield return null; //aspettiamo un frame
        }
        Debug.Log("All managers started up");

    }
 
    // Start is called before the first frame update
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {

    }
}