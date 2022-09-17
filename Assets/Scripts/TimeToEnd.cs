using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class TimeToEnd : MonoBehaviour
{

    [SerializeField] private int LevelDuration;


    // Start is called before the first frame update
    void Start()
    {
        Timer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Timer()
    {

        if (LevelDuration > 1)
        {
             Debug.Log("Value of levelDuration is " + LevelDuration);
            LevelDuration--;
            Invoke("Timer", 1.0f);

            UiManager.instance.UpdateDuration(LevelDuration);


        }

        else if (LevelDuration == 1)
        {
            Debug.Log("GameOver");
            GameManager.instance.EndGame();
        }

    }
}
