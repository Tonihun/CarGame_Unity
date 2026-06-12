using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    //Car speed tuning
    public float speed;
    public float turnSpeed;

    //Input for the movement (WASD)
    public InputAction Movement;

    //The current input value
    public Vector2 movementInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Enable the InputAction, thus making it able to read the input keys
        Movement.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        //Reads the current Input keys
        movementInput = Movement.ReadValue<Vector2>();

        //Car movement forwards and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementInput.y);

        //Car movement to left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * movementInput.x);


     }
}
