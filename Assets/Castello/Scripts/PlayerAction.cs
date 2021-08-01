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

            RaycastHit hit;

            if (Physics.Raycast(transform.position, Vector3.forward, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                Debug.Log(hitObject);
                
                if (hitObject.GetComponent<CastelloPortone>() != null && hit.distance < 5f)
                {
                    hitObject.GetComponent<CastelloPortone>().React();
                }
            }
        }
    }
}
