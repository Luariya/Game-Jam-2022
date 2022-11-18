using UnityEngine;

public class JumpingChar : MonoBehaviour
{
    [SerializeField] private float jumpPower = 5.0f;

    private Rigidbody2D _playerRigidbody;
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }
    private void Update()
    {

        if (Input.GetButton("Jump") && IsGrounded())
            Jump();
    }
    
    private void Jump() => _playerRigidbody.velocity = new Vector2(0, jumpPower);

    private bool IsGrounded()
    {
        var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    }


}