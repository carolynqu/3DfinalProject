using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterMotor))]
[AddComponentMenu("Character/FPS Input Controller")]
public class FPSInputController : MonoBehaviour
{
	private CharacterMotor motor;

	void Awake()
	{
		motor = GetComponent<CharacterMotor>();
	}

	// Update is called once per frame
	void Update()
	{
		// Get the input vector from keyboard or analog stick
		Vector3 directionVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		if (directionVector != Vector3.zero)
		{
			float directionLength = directionVector.magnitude;
			directionVector = directionVector / directionLength;

			directionLength = Mathf.Min(1, directionLength);

			directionLength = directionLength * directionLength;

			directionVector = directionVector * directionLength;
		}

		// Apply the direction to the CharacterMotor
		motor.inputMoveDirection = transform.rotation * directionVector;
		motor.inputJump = Input.GetButton("Jump");
	}
}
