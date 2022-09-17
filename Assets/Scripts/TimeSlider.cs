using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    public static TimeSlider instance;

    public GameObject timerCountdown;
    public Slider timerSlider;
    public float gameTime;
    public float maxValue;

    public float time;

    [SerializeField] private Animator TimeLeftAnimator; 

    public bool stopGame;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerCountdown.SetActive(false);
        maxValue = 31;
        stopGame = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        //float time = gameTime - Time.time;
        maxValue -= Time.deltaTime;
        time = (int) maxValue;
        
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60);


        if (time <= 0)
        {
            stopGame = true;
        }

        if (time < 25 && time>=0)
        {
            timerCountdown.SetActive(true);
            UiManager.instance.TimerCountdown.text = time.ToString();
        }

        else
        {
            timerCountdown.SetActive(false);
        }

        if(stopGame == false)
        {
            timerSlider.value = time;
        }
    }
}
