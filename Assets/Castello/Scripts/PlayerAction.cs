using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f")) //pulsante sinistro
        {
            /*RaycastHit[] hits;
            hits = Physics.RaycastAll(transform.position, transform.forward, 10.0f);
            for (int i = 0; i < hits.Length; i++)
            {
                GameObject hitObject = hits[i].transform.gameObject;
                if (hitObject.GetComponent<CastelloPortone>() != null)
                {
                    hitObject.GetComponent<CastelloPortone>().React();
                }
                else if (hitObject.GetComponent<NPC>() != null)
                {
                	Debug.Log("hitted npc");
                    hitObject.GetComponent<NPC>().React();
                }
            }*/

            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.forward, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                Debug.Log(hitObject);
                
                if (hitObject.GetComponent<CastelloPortone>() != null && hit.distance < 10f)
                {
                    Debug.Log("hittato");
                    hitObject.GetComponent<CastelloPortone>().React();
                }
                else if (hitObject.GetComponent<NPC>() != null && hit.distance < 10f)
                {
                	Debug.Log("hittato npc");
                    hitObject.GetComponent<NPC>().React();
                }
            }
        }
    }
}
