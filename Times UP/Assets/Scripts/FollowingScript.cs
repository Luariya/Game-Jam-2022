using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    private float m_Speed;
    Rigidbody2D m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Speed = 1f;
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.up * m_Speed;
    }
}
