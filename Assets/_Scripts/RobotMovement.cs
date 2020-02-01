using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RobotMovement : MonoBehaviour
{

    public int player;
    public bool inverted;
    [SerializeField]
    public Track leftTrack, rightTrack;
    
    public float brakingMultiplier;
    public float rotationMultiplier;

    private float currentSpeed;
    private float currentRotatiom;
    private Rigidbody rb;
    private bool speedCalculated;
    private bool forward;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {

        }
        if(Input.GetKey(KeyCode.UpArrow))
        {

        }
        if(Input.GetKey(KeyCode.S))
        {

        }
        if(Input.GetKey(KeyCode.DownArrow))
        {

        }
    }

    private void FixedUpdate() 
    {
        int input = 0;
        if(inverted)
        {
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
        } else
        {
            if(Input.GetKey(KeyCode.W))
            {
                input += 10;
            }
            if(Input.GetKey(KeyCode.S))
            {
                input += 100;
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                input += 1000;
            }
            if(Input.GetKey(KeyCode.DownArrow))
            {
                input += 1;
            }
        }
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
            case 0110:// rotate right
                currentRotatiom += leftTrack.rotationSpeed + rightTrack.rotationSpeed;
                CalculateRotation(true,1);
                speedCalculated = false;
                break;
            case 1001:// rotate left
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
                if (currentSpeed < 0) currentSpeed = 0;
            } else if (currentSpeed < 0)
            {
                currentSpeed += ((leftTrack.acceleration + rightTrack.acceleration)/2)*brakingMultiplier;
                if (currentSpeed > 0) currentSpeed = 0;
            } else currentSpeed = 0;
            
        }
        rb.MovePosition(transform.position + transform.forward * currentSpeed * Time.deltaTime);
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
        }else 
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
        else
        {
            if (currentSpeed > -track.maxSpeed)
            {
                currentSpeed -= track.acceleration;
            }
        }
        speedCalculated = true;
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
