using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RobotMovement : MonoBehaviour
{

    public int player;
    public bool inverted;
    [SerializeField]
    public Track leftTrack, rightTrack;
    
    public float brakingMultiplier;
    public float rotationMultiplier;

    PlayerControls controls;
    private int input;
    private float currentSpeed;
    private float currentRotatiom;
    private Rigidbody rb;
    private bool speedCalculated;
    private bool forward;

    private void Awake() {
        controls = new PlayerControls();
        SetControls();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
/*
        if(Input.GetKey(KeyCode.W))
        {
            input += 1000;
        }
        if(Input.GetKey(KeyCode.S))
        {
            input += 1;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            input += 10;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            input += 100;
        }
    */
        speedCalculated = true;
        currentRotatiom = 0;
        switch(input)
        {
            case 1000: //+left
                calculateSpeed(leftTrack, true);
                currentRotatiom -= leftTrack.rotationSpeed;
                CalculateRotation(false,-1);
            break;
            case 0100: //-left
                calculateSpeed(leftTrack, false);
                currentRotatiom -= leftTrack.rotationSpeed;
                CalculateRotation(false,-1);
                break;
            case 0010://+right
                calculateSpeed(rightTrack, true);
                currentRotatiom += rightTrack.rotationSpeed;
                CalculateRotation(false,1);
                break;
            case 0001://-right
                calculateSpeed(rightTrack, false);
                currentRotatiom += rightTrack.rotationSpeed;
                CalculateRotation(false,1);
                break;
            case 1100:// rotate right
                currentRotatiom += leftTrack.rotationSpeed + rightTrack.rotationSpeed;
                CalculateRotation(true,1);
                speedCalculated = false;
                break;
            case 0011:// rotate left
                currentRotatiom -= leftTrack.rotationSpeed + rightTrack.rotationSpeed;
                CalculateRotation(true,1);
                speedCalculated = false;
                break;
            case 1010: //forward
                calculateSpeed(leftTrack, true);
                calculateSpeed(rightTrack, true);
                currentRotatiom = leftTrack.rotationSpeed - rightTrack.rotationSpeed;
                CalculateRotation(true,1);
                break;
            case 0101: //backwards
                calculateSpeed(leftTrack, false);
                calculateSpeed(rightTrack, false);
                currentRotatiom = leftTrack.rotationSpeed - rightTrack.rotationSpeed;
                CalculateRotation(true,1);
                break;
            default:
                speedCalculated = false;
                break;
        }

        #region Movement
        /*
        speedCalculated = false;
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        {
            calculateSpeed(leftTrack, true);
            calculateSpeed(rightTrack, true);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow))
        {
            calculateSpeed(leftTrack, false);
            calculateSpeed(rightTrack, false);
        }*/
        if(!speedCalculated)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= ((leftTrack.acceleration + rightTrack.acceleration)/2)*brakingMultiplier;

                if (currentSpeed < 0)
                 currentSpeed = 0;
            }
            else if (currentSpeed < 0)
            {
                currentSpeed += ((leftTrack.acceleration + rightTrack.acceleration)/2)*brakingMultiplier;

                if (currentSpeed > 0)
                 currentSpeed = 0;
            } 
            else
             currentSpeed = 0;
            
        }
        Vector3 desiredPosition = transform.position + transform.forward * currentSpeed * Time.deltaTime;
        Vector3 direction = desiredPosition - transform.position;
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hit;
        if (!Physics.Raycast(ray,out hit,direction.magnitude))
            rb.MovePosition(desiredPosition);
        else
            rb.MovePosition(hit.point);
        //rb.MovePosition(transform.position + transform.forward * currentSpeed * Time.deltaTime);
        #endregion

        #region Rotation
        /*
        bool canRotate = true;
        if (canRotate)
        {
            currentRotatiom = 0;
            if(Input.GetKey(KeyCode.S))
            {
                currentRotatiom += leftTrack.rotationSpeed;
            }
            if(Input.GetKey(KeyCode.DownArrow))
            {
                currentRotatiom -= rightTrack.rotationSpeed;
            }
            if(Input.GetKey(KeyCode.W))
            {
                currentRotatiom -= leftTrack.rotationSpeed;
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                currentRotatiom += rightTrack.rotationSpeed;
            }
        }*/
        
        #endregion
    }
    void CalculateRotation(bool aroundSelf,int dir)
    {
        if(aroundSelf)
        {
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0,currentRotatiom,0) * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        else 
        {
            Vector3 origin = new Vector3(dir,transform.position.y, transform.position.z);
            Quaternion q = Quaternion.AngleAxis(rotationMultiplier * currentRotatiom/ 10, Vector3.up);
            
            rb.MovePosition(q * (rb.transform.position - origin) + origin);
            rb.MoveRotation(rb.transform.rotation * q);
        }   
    }
    void calculateSpeed(Track track, bool forward)
    {
        if (forward)
        {
            if (currentSpeed < track.maxSpeed)
            {
                currentSpeed += track.acceleration;
            }
        }
        else if (currentSpeed > -track.maxSpeed)
        {
            currentSpeed -= track.acceleration;
        }
        
        speedCalculated = true;
    }
    private void OnEnable() 
    {
        controls.RobotMovement.L1.Enable();
        controls.RobotMovement.L2.Enable();
        controls.RobotMovement.R1.Enable();
        controls.RobotMovement.R2.Enable();
        controls.RobotMovement.A.Enable();
    }
    private void OnDisable() 
    {
        controls.RobotMovement.L1.Disable();
        controls.RobotMovement.L2.Disable();
        controls.RobotMovement.R1.Disable();
        controls.RobotMovement.R2.Disable();
        controls.RobotMovement.A.Disable();
    }
    private void SetControls()
    {
        controls.RobotMovement.L1.performed += context => CalculateInput(1000);
        controls.RobotMovement.L2.started += context => CalculateInput(1);
        controls.RobotMovement.R1.performed += context => CalculateInput(10);
        controls.RobotMovement.R2.started += context => CalculateInput(100);
        controls.RobotMovement.L1.canceled += context => CalculateInput(-1000);
        controls.RobotMovement.L2.canceled += context => CalculateInput(-1);
        controls.RobotMovement.R1.canceled += context => CalculateInput(-10);
        controls.RobotMovement.R2.canceled += context => CalculateInput(-100);
        //controls.RobotMovement.A.performed += context => CalculateInput(1000);
    }

    void CalculateInput(int i)
    {
        input += i;
    }
}
[System.Serializable]
public class Track
{
    public int maxSpeed;
    public float acceleration;
   // public float maxRotationSpeed;
    public float rotationSpeed;
}
