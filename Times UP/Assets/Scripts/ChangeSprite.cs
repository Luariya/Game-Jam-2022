using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public GameObject child, parent, grandparent;

    public CountDown countDown;

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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ChildToAdult")
        {
            child.SetActive(false);
            parent.SetActive(true);
            grandparent.SetActive(false);
        }

        if (other.tag == "AdultToGrandparent")
        {
            child.SetActive(false);
            parent.SetActive(false);
            grandparent.SetActive(true);
        }
        if (other.tag == "Powerup")
        {
            countDown.CurrentTime += 5f;
            Nixon(other.gameObject);
        }
    }

    private void Nixon(GameObject gO)
    {
        Destroy(gO);
        //if else klausel in kurz geschrieben unten
        //int f = (4 == 4) ? 5 : 7; 

    }
}
