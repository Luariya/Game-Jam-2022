using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject objectToActivateAndDeactivate;
    // Start is called before the first frame update
    void Start()
    {
        objectToActivateAndDeactivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DeathByCollide")
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            objectToActivateAndDeactivate.SetActive(true);
        }
    }
}
