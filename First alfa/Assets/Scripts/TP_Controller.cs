using UnityEngine;
using System.Collections;

public class TP_Controller : MonoBehaviour
{
	public static CharacterController CharacterControler;
	public static TP_Controller Instance;

	void Awake() 
	{
		CharacterControler = GetComponent("CharacterController") as CharacterController;
		Instance = this;
		
	}
	

	void Update() 
	{
		if (Camera.mainCamera == null )
			return;
		
		GetLocomotionInput();	
	}
	
	void GetLocomotionInput()
	{
		
	}
}
