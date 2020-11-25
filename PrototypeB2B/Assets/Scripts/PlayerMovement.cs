using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float movementSpeed;
    private Rigidbody thisRigidbody;
    private const float SPEEDMULTOFFSET = 100f;

    private void Awake()
    {
        thisRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movementDirection = new Vector3(playerInput.HorizontalX, 0f, playerInput.HorizontalZ);
        thisRigidbody.velocity = movementDirection.normalized * movementSpeed * SPEEDMULTOFFSET * Time.fixedDeltaTime;
    }
}
