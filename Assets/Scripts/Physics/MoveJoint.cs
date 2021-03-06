using UnityEngine;

/// <summary>
/// Script to simulate a moving platform using the Slider Joint 2d
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class MoveJoint : MonoBehaviour
{
    /// <summary>
    /// Which joint 2d is being used by this object
    /// </summary>
    public JointType whichJoint;

    /// <summary>
    /// Float used as positive speed for the motor
    /// </summary>
    public float PositiveSpeed = 1f;

    /// <summary>
    /// Float used as negative speed for the motor
    /// </summary>
    public float NegativeSpeed = -1f;

    /// <summary>
    /// The object slider joint 2d
    /// </summary>
    private SliderJoint2D _slider;

    /// <summary>
    /// The object hinge joint 2d
    /// </summary>
    private HingeJoint2D _hinge;

    /// <summary>
    /// The slider joint 2d motor
    /// </summary>
    private JointMotor2D _auxiliarymotor;

    /// <summary>
    /// Initialize the variables
    /// </summary>
    void Start()
    {
        switch (whichJoint)
        {
            case JointType.SLIDER:
                _slider = GetComponent<SliderJoint2D>();
                _auxiliarymotor = _slider.motor;
                break;
            case JointType.HINGE:
                _hinge = GetComponent<HingeJoint2D>();
                _auxiliarymotor = _hinge.motor;
                break;
        }
    }

    /// <summary>
    /// If the slider / hinge reached its lower limit, set its motor speed to a positive value
    /// If the slider / hinge reached its upper limit, set its motor speed to a negative value
    /// </summary>
    void Update()
    {
        switch (whichJoint)
        {
            case JointType.SLIDER:
                if (_slider.limitState == JointLimitState2D.LowerLimit)
                {
                    _auxiliarymotor.motorSpeed = PositiveSpeed;
                    _slider.motor = _auxiliarymotor;
                }

                if (_slider.limitState == JointLimitState2D.UpperLimit)
                {
                    _auxiliarymotor.motorSpeed = NegativeSpeed;
                    _slider.motor = _auxiliarymotor;
                }
                break;
            case JointType.HINGE:
                if (_hinge.limitState == JointLimitState2D.LowerLimit)
                {
                    _auxiliarymotor.motorSpeed = PositiveSpeed;
                    _hinge.motor = _auxiliarymotor;
                }

                if (_hinge.limitState == JointLimitState2D.UpperLimit)
                {
                    _auxiliarymotor.motorSpeed = NegativeSpeed;
                    _hinge.motor = _auxiliarymotor;
                }
                break;
        }
        
    }

    // Trying to find a solution as to make the player position follow the platform
    // After some research, found the solution below, but only works when the platform rigid body is set to Kinematic
    // Which is not ideal, since the idea is to make use of the slider joint motor function, that works only when the rigid body is set to Dynamic
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }*/

    /// <summary>
    /// Enum used to determine which joint is being used
    /// </summary>
    public enum JointType
    {
        SLIDER,
        HINGE
    }
}
