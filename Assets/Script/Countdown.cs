using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public string scenename;
    private float currentTime = 0f;
    private float StartingTime = 120f ;

    public Text countdownTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = StartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownTime.text = currentTime.ToString("Time : 0");



        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(scenename);
        }
    }
}
