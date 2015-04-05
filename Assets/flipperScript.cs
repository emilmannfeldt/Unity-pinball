using UnityEngine;
using System.Collections;

public class flipperScript : MonoBehaviour {

    public Rigidbody2D rd;
    public HingeJoint2D hj;
    public JointMotor2D motor;
    
    public float torque;
    public float speed;
	void Start() {
        
        motor = hj.motor;
        motor.motorSpeed = speed;
        motor.maxMotorTorque = torque;
        hj.motor = motor;
        hj.useMotor = false;
	}
	void Update() {
        
        if (Input.GetMouseButtonDown(0))
        {
           

            
            hj.useMotor = true;
          
        }
        if (Input.GetMouseButtonUp(0))
        {
            hj.useMotor = false;
        }
       
	
	}

}
