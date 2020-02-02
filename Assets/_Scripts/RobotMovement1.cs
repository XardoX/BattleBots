using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RobotMovement1 : MonoBehaviour
{

    [SerializeField]
    public Track1 leftTrack, rightTrack;
    
    public float brakingMultiplier;
    public float rotationMultiplier;
    public bool bounce;
    public float bouncePower;

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
        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
    }

    private void FixedUpdate() 
    {
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
                rb.angularVelocity = Vector3.zero;
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
        float brakeFloat = ((leftTrack.acceleration + rightTrack.acceleration)/2)*brakingMultiplier;
        if(!speedCalculated)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -=brakeFloat;

                if (currentSpeed < 0)
                 currentSpeed = 0;
            }
            else if (currentSpeed < 0)
            {
                currentSpeed += brakeFloat;

                if (currentSpeed > 0)
                 currentSpeed = 0;
            } 
            else
             currentSpeed = 0;
           
            if (rb.velocity != Vector3.zero && currentSpeed == 0)
            {
                if (rb.velocity.x > 0)
                {
                    rb.velocity -= new Vector3(brakeFloat,0,0);
                    if (rb.velocity.x < 0)
                    rb.velocity = Vector3.zero;
                } else if (rb.velocity.x < 0)
                {
                    rb.velocity += new Vector3(brakeFloat,0,0);
                    if (rb.velocity.x > 0)
                    rb.velocity = Vector3.zero;
                }
                if (rb.velocity.z > 0)
                {
                    rb.velocity -= new Vector3(0,0,brakeFloat);
                    if (rb.velocity.x < 0)
                    rb.velocity = Vector3.zero;
                } else if (rb.velocity.z < 0)
                {
                    rb.velocity += new Vector3(0,0,brakeFloat);
                    if (rb.velocity.x > 0)
                    rb.velocity = Vector3.zero;
                }
            }
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
    private void LateUpdate() {
        //input = 0;
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
        FindObjectOfType<AudioManager>().Play("Drive");
    }
    void calculateSpeed(Track1 track, bool forward)
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
        FindObjectOfType<AudioManager>().Play("Drive");
        speedCalculated = true;
    }/*
    public void OnConfirm()
    {
        Debug.Log(player);
    }
    private void OnLeftTrackForward()
    {
         input += 1000;
    }
    private void OnLeftTrackBackward()
    {
         input += 1;
    }
    private void OnRightTrackForward()
    {
         input += 10;
    }
    private void OnRightTrackBackward()
    {
         input += 100;
         Debug.Log(player);
    }
    */
    private void OnEnable() 
    {
        controls.PlayerTwo.LeftTrackForward.Enable();
        controls.PlayerTwo.LeftTrackBackward.Enable();
        controls.PlayerTwo.RightTrackForward.Enable();
        controls.PlayerTwo.RightTrackBackward.Enable();
        controls.PlayerTwo.Confirm.Enable();
    }
    private void OnDisable() 
    {
        controls.PlayerTwo.LeftTrackForward.Disable();
        controls.PlayerTwo.LeftTrackBackward.Disable();
        controls.PlayerTwo.RightTrackForward.Disable();
        controls.PlayerTwo.RightTrackBackward.Disable();
        controls.PlayerTwo.Confirm.Disable();
    }
    private void SetControls()
    {
        controls.PlayerTwo.LeftTrackForward.performed += context => CalculateInput(1000);
        controls.PlayerTwo.LeftTrackBackward.started += context => CalculateInput(1);
        controls.PlayerTwo.RightTrackForward.performed += context => CalculateInput(10);
        controls.PlayerTwo.RightTrackBackward.started += context => CalculateInput(100);
        controls.PlayerTwo.LeftTrackForward.canceled += context => CalculateInput(-1000);
        controls.PlayerTwo.LeftTrackBackward.canceled += context => CalculateInput(-1);
        controls.PlayerTwo.RightTrackForward.canceled += context => CalculateInput(-10);
        controls.PlayerTwo.RightTrackBackward.canceled += context => CalculateInput(-100);
        //controls.PlayerTwo.Confirm.performed += context => CalculateInput(1000);
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(bounce)
        {
            if (other.gameObject.tag == "Player")
            {
                //other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward* bouncePower);
                currentSpeed = -currentSpeed/2;
            }else  if (other.gameObject.tag == "Bouncable") currentSpeed = -currentSpeed * bouncePower;
        }
    }

    void CalculateInput(int i)
    {
        input += i;
    }

    public void SetSpeedlvl(float leftSpeed, float rightSpeed, float leftRotation, float rightRotation)
    {
        leftTrack.acceleration = leftSpeed;
        rightTrack.acceleration = rightSpeed;
        leftTrack.rotationSpeed = leftRotation;
        rightTrack.rotationSpeed = rightRotation;
    }
    
}
[System.Serializable]
public class Track1
{
    public int maxSpeed;
    public float acceleration;
   // public float maxRotationSpeed;
    public float rotationSpeed;
}
