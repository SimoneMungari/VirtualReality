using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]


public class RelativeMovement : MonoBehaviour
{
	[SerializeField] private Transform target;
	
	public float rotSpeed = 15.0f;
	
	public float gravity = -9.8f;
	
	public float moveSpeed = 6.0f;
	private CharacterController _charController;
	
	
    // Start is called before the first frame update
    void Start()
    {	
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 movement = Vector3.zero;
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        
        if (horInput != 0 || vertInput != 0)
        {
        	movement.x = horInput * moveSpeed;
        	movement.z = vertInput * moveSpeed;
        	movement = Vector3.ClampMagnitude(movement, moveSpeed);
        	
        	Quaternion tmp = target.rotation;
        	target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
        	movement = target.TransformDirection(movement);
        	target.rotation = tmp;
        	
        	Quaternion direction = Quaternion.LookRotation(movement);
        	//Il LERP serve per far fare al player un movimento naturale e non cambiare di botto la sua posizione
        	transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotSpeed * Time.deltaTime);
        }
        
        movement.y = gravity;
        movement *= Time.deltaTime;
        _charController.Move(movement);
    }
    
}
