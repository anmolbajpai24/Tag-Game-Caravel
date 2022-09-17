using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int LevelDuration;
    // public float TimerBeforeStart = 3;
    //public bool TimerBeforeStartHasEnded = false;
    public Animator animator;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject arrow;

    public bool GameEnded = false;

    public float time;

    //public GameObject flikeringLights;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;

        
        animator = Player.GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Timer();

       // StartCoroutine("flicker");
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().name == "MainMenu")
        //{
        TimeFunc();
        LastSeconds();
       

    }

    private void FixedUpdate()
    {
        // StartCoroutine("flicker");
        
        
        print("THE TIME IS "+ time);
    }

    public void LastSeconds()
    {
        if(time == 10)
        {
            
        }
    }

    public void Timer()
    {

        if (LevelDuration > 1)
        {
            ///  Debug.Log("Value of levelDuration is " + LevelDuration);
            LevelDuration--;
            Invoke("Timer", 1.0f);

            UiManager.instance.UpdateDuration(LevelDuration);


        }

        else if (LevelDuration == 1)
        {
            Debug.Log("GameOver");
            WinGame();
        }

    }

    public void TimeFunc()
    {
        time = LevelDuration;
        time -= Time.deltaTime;

        
    }
   // IEnumerator flicker()
    //{
       
        
        //   flikeringLights.SetActive(true);
          //  yield return new WaitForSeconds(2);
           // flikeringLights.SetActive(false);
        

    //}

    public void StartButtonPress()
    {
        Debug.Log("pressed");

        StartCoroutine("StartDelay");

            //if (!TimerBeforeStartHasEnded)
            
        /* {
       
            TimerBeforeStart -= Time.unscaledDeltaTime;
        
           // TimerBeforeStart -= Time.unscaledDeltaTime;

            if (TimerBeforeStart <= 0)
            {
                TimerBeforeStartHasEnded = true;
                
                Debug.Log("Timer" + TimerBeforeStartHasEnded);
                StartGame();
                //UiManager.instance.DisableTimer();
           
        }
        
        }
        */ 

        //yield return new WaitForSecondsRealtime(3);


    }

    IEnumerator StartDelay()
    {
        UiManager.instance.Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text3.SetActive(false);


        UiManager.instance.Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text2.SetActive(false);


        UiManager.instance.Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text1.SetActive(false);




        StartGame();

    }

   

    #region LoadingOfScenes
    public void StartGame()
    {
        // Loading the scene 
        // if (TimerBeforeStartHasEnded)
        // {
        UiManager.instance.StartPanel.SetActive(false);
        UiManager.instance.Joystick.SetActive(true);
        Time.timeScale = 1f;
       // }
      
        //SceneManager.LoadScene("DemoSceneRigidbody");

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("VideoRecordingScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("VideoRecordingScene");
    }

    public void EndGame()
    {
        GameEnded = true;
        // Loading Game Over Scene 
        // SceneManager.LoadScene("GameOver");
        UiManager.instance.Joystick.SetActive(false);
        //Time.timeScale = 0;

        animator.SetBool("Died", true);
      // DestroyOnCollision.instance.Emoji.SetActive(false);


        if (animator.GetBool("Won")== false)
        {

            UiManager.instance.GameOverPanel.SetActive(true);
        }

        TimeSlider.instance.stopGame = true;
        // ChangeImage.instance.imageOnRed.enabled = false;

        // Time.timeScale = 0;
        Destroy(arrow);
    }

    public void WinGame()
    {
        UiManager.instance.Joystick.SetActive(false);
        //Time.timeScale = 0;
       // UiManager.instance.GameWinPanel.SetActive(true);

        Destroy(Enemy);
        Destroy(arrow);

       // DestroyOnCollision.instance.Emoji.SetActive(false);

        if (animator.GetBool("Died") == false)
        {

            UiManager.instance.GameWinPanel.SetActive(true);
        }

        GameEnded = true;
        animator.SetBool("Won", true);

      //  ChangeImage.instance.imageOnRed.enabled = false;

        
    }

    #endregion

}