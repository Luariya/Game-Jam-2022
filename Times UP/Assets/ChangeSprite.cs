using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public GameObject child;
    public GameObject parent;
    public GameObject grandparent;

    // Start is called before the first frame update
    void Start()
    {
        child.SetActive(true);
        parent.SetActive(false);
        grandparent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "ChildToAdult")
        {
            child.SetActive(false);
            parent.SetActive(true);
        }

        if (other.tag == "AdultToGrandparent")
        {
            parent.SetActive(false);
            grandparent.SetActive(true);
        }
    }
}
