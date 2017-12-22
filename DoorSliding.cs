using UnityEngine;
using System.Collections;

public class DoorSliding: MonoBehaviour {
	
	SliderJoint2D door;
	JointMotor2D doorMotor;
	//Sliding speed of the door. Can be changed via the inspector
	public int slideSpeed = 100;
	//flag to determine if the door is closed or open
	bool isDoorOpen = false;
	// Use this for initialization
	void Start () {
		//get the sliderJoint2D component attached to the door object
		door = gameObject.GetComponent<SliderJoint2D>();
		//we will use the jointMotor2D to add speed and later set it back to the SliderJoint2D's motor as setting the motor speed of the sliderJoint2D doesn't work.
		doorMotor = door.motor;
	}
	
	// Update is called once per frame
	void Update () {
		//check if the spacebar key is pressed
		if(Input.GetKeyDown(KeyCode.E)){
			//check if the door is already open
			if(!isDoorOpen)
				//set the motor speed to +100 so that the door will slide open
				doorMotor.motorSpeed = slideSpeed;

			else
				//set the motor speed to -100 so that the door will close
				doorMotor.motorSpeed = -slideSpeed;
			//invert the isDoorOpen flag once the door is opened or closed
			isDoorOpen = !isDoorOpen;
		}
		//set the sliderJoint2D's motor speed
		door.motor = doorMotor;
	}
}