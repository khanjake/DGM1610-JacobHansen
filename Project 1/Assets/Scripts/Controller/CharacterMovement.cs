using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 positionDirection;
    public float characterSpeedMultipler = 5f;
    private float gravity = -1f;
    public float jumpForce = 5f;
    private int numberOfJumps = 0;
    public int maxJumpCount = 2;
    public UnityEvent jumpEvent;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            numberOfJumps = 0;
        }
        positionDirection.x = Input.GetAxis("Horizontal")*characterSpeedMultipler;
        if (Input.GetButtonDown("Jump") && numberOfJumps < maxJumpCount)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            numberOfJumps++;
        }
        positionDirection.y += gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
