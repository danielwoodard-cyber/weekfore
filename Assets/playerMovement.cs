using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public InputActionAsset actions;
    public float playerSpeed = 5f;

    InputAction move, jump;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        move = actions.FindAction("player/move");
        jump = actions.FindAction("player/jump");
    }

    void OnEnable() { jump.performed += OnJump; actions.Enable(); }
    void OnDisable() { jump.performed+= OnJump; actions.Disable(); }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 input = move.ReadValue<Vector2>();
        transform.Translate(new Vector3(input.x, 0, input.y) * playerSpeed * Time.deltaTime);
    }
    
    void OnJump(InputAction.CallbackContext ctx)
    {
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }
}
