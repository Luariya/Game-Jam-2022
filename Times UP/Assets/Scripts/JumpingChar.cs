using UnityEngine;

public class JumpingChar : MonoBehaviour
{
    public bool isGrounded = false;
    [SerializeField] private float jumpPower = 5.0f;

    private Rigidbody2D _playerRigidbody;
    private void Start()
    {

    }
    void Update ()
    {
        Jump();
    }
    void Jump()
    {

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

}