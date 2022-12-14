using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public GameObject objectToActivateAndDeactivate;
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] TMP_Text countdownText;

    public float CurrentTime 
    { 
        get => currentTime; set => currentTime = value; 
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00.0");

        if (currentTime <= 3)
        {
            countdownText.color = Color.red;
        }
        else
        {
            countdownText.color = Color.white;
        }

        if (currentTime <= 0)
        {
            Time.timeScale = 0;
            Destroy(GameObject.FindWithTag("Player"));
            objectToActivateAndDeactivate.SetActive(true);
        }
    }
}
