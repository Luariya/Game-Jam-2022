using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public GameObject child, parent, grandparent;

    public CountDown countDown;

    [SerializeField] private AudioSource uhr;
    [SerializeField] private AudioSource kindermukke;
    [SerializeField] private AudioSource erwachsenenmukke;
    [SerializeField] private AudioSource techno;

    // Start is called before the first frame update

    void Start()
    {
        child.SetActive(true);
        parent.SetActive(false);
        grandparent.SetActive(false);
        kindermukke.Play();
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
            kindermukke.Stop();
            erwachsenenmukke.Play();

        }

        if (other.tag == "AdultToGrandparent")
        {
            child.SetActive(false);
            parent.SetActive(false);
            grandparent.SetActive(true);
            erwachsenenmukke.Stop();
            techno.Play();
        }
        if (other.tag == "Powerup")
        {
            uhr.Play();
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
