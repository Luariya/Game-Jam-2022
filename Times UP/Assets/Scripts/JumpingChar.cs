using UnityEngine;

public class JumpingChar : MonoBehaviour
{
    public bool isGrounded = false;
    

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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
    }

}