using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JumpingThroughStuff : MonoBehaviour
{
    Rigidbody2D rb;
    int playerLayer, platformLayer;
    bool jumpOffCoroutineIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerLayer = LayerMask.NameToLayer("Player");
        platformLayer = LayerMask.NameToLayer("Platform");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && !jumpOffCoroutineIsRunning)
        {
            StartCoroutine("JumpOff");
        }

        if (rb.velocity.y > 0)
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, true);

        else if (rb.velocity.y <= 0 && !jumpOffCoroutineIsRunning)
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
    }
    IEnumerator JumpOff()
    {
        jumpOffCoroutineIsRunning = true;
        Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, true);
        yield return new WaitForSeconds(0.5f);
        Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
        jumpOffCoroutineIsRunning = false;
    }

}
