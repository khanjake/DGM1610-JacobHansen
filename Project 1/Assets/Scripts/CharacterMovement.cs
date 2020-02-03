using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    public float characterSpeedMultipler = 5f;
    private float gravity = -1.5f;
    public float jumpForce = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*characterSpeedMultipler;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.y += gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
