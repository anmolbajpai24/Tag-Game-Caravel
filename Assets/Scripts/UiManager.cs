using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public Text Duration;
    //public Slider slider;
    public Text TimerCountdown;
    public Text RemainingTime;

    public GameObject StartPanel;
    public GameObject GameOverPanel;
    public GameObject GameWinPanel;
    public GameObject Joystick;

    public GameObject Text3;
    public GameObject Text2;
    public GameObject Text1;

    public Text CoinCounterText;

    public Image AmazingText;
    public Image SadEmoji;

    public Transform currentTextImage;
    public Transform currentText;


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
       // StartCoroutine("TimeDisplay");
    }

    // Update is called once per frame
    void Update()
    {
        CoinCounterText.text = DestroyOnCollision.instance.CoinCounter.ToString();

       

        //if (GameManager.instance.time == 10.98)
     //   {

     //       TimerCountdown.text = GameManager.instance.time.ToString("0");
      // }
     //   TimerCountdown.text = GameManager.instance.time.ToString();
        

    }

    IEnumerator TimeDisplay()
    {
       yield return new WaitForSeconds(5);
        TimerCountdown.text = GameManager.instance.time.ToString("0");

    }

    public void DisplayTheEmoji()
    {
        AmazingTextAnimationController.Instance.PlayOneAnimationRandomly();
    }
    public void DisplayEmoji()
    {
       
        DestroyOnCollision.instance.CoinCounter+=10;
       
        currentTextImage.localScale = Vector3.zero;
        currentTextImage.GetComponent<SpriteRenderer>().DOFade(1, 0.1f);

        currentTextImage.DOScale(Vector3.one, 3).SetDelay(1);
        float currentPositionY = currentText.transform.position.y;
        currentText.transform.DOMoveY(currentPositionY + 5, 4).SetDelay(1);
        currentTextImage.GetComponent<SpriteRenderer>().DOFade(0, 3).SetDelay(3f);

      

        currentText.transform.DOMoveY(currentPositionY, 0.1f).SetDelay(5);
        

    }

    public void DisableTimer()
    {
        TimerCountdown.enabled = false;
    }

    IEnumerator EnableText()
    {
        //AmazingText.SetEnable(true);
        yield return new WaitForSeconds(1f);
       // AmazingText.SetEnable(false);

       
    }

    public void UpdateDuration(int dur)
    {
        
        Duration.text = dur.ToString();
       // slider.value = dur;
        //slider.maxValue = GameManager.instance.LevelDuration;

    }
}
