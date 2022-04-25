using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]
    private float glideSpeed = 25.0f;
    [SerializeField]
    private float boostSpeed = 100.0f;
    [SerializeField]
    private float pitchSpeed = 100.0f;
    [SerializeField]
    private float rollSpeed = 100.0f;
    [SerializeField]
    private float yawSpeed = 100.0f;

    private bool pitchDown = false;
    private bool pitchUp = false;
    private bool rollLeft = false;
    private bool rollRight = false;
    private bool yawLeft = false;
    private bool yawRight = false;
    private bool boost = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pitchDown)
        {
            transform.Rotate(new Vector3(pitchSpeed * Time.deltaTime, 0, 0), Space.Self);
        }
        if(pitchUp)
        {
            transform.Rotate(new Vector3(-pitchSpeed * Time.deltaTime, 0, 0), Space.Self);
        }
        if(rollLeft)
        {
            transform.Rotate(new Vector3(0, 0, rollSpeed * Time.deltaTime), Space.Self);
        }
        if(rollRight)
        {
            transform.Rotate(new Vector3(0, 0, -rollSpeed * Time.deltaTime), Space.Self);
        }
        if(yawLeft)
        {
            transform.Rotate(new Vector3(0, -yawSpeed * Time.deltaTime, 0), Space.Self);
        }
        if(yawRight)
        {
            transform.Rotate(new Vector3(0, yawSpeed * Time.deltaTime, 0), Space.Self);
        }

        if(boost)
        {
            transform.Translate(new Vector3(0, 0, boostSpeed * Time.deltaTime), Space.Self);
        }
        else
        {
            transform.Translate(new Vector3(0, 0, glideSpeed * Time.deltaTime), Space.Self);
        }
    }

    void OnPitchDown(InputValue value)
    {
        pitchDown = !pitchDown;
    }

    void OnPitchUp(InputValue value)
    {
        pitchUp = !pitchUp;
    }

    void OnRollLeft(InputValue value)
    {
        rollLeft = !rollLeft;
    }

    void OnRollRight(InputValue value)
    {
        rollRight = !rollRight;
    }

    void OnYawLeft(InputValue value)
    {
        yawLeft = !yawLeft;
    }

    void OnYawRight(InputValue value)
    {
        yawRight = !yawRight;
    }

    void OnBoost(InputValue value)
    {
        boost = !boost;
    }
}
