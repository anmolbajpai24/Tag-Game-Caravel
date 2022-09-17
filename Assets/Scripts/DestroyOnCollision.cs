using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Feedbacks;


// This script is detecting the collision with enemy and also the coins


public class DestroyOnCollision : MonoBehaviour
{
    public static DestroyOnCollision instance;
    public GameObject Enemy;
    public GameObject Emoji;

    public int CoinCounter=0;
    public bool isDone = false;

    public BoxCollider boxCollider;

    [SerializeField] private MMFeedback shakeScreen;
    [SerializeField] private MMFeedback shakeScreenLight;
    [SerializeField] private MMFeedback CameraZoom;

    //[SerializeField] private Animator cryEmoji;
    [SerializeField] private Animator cryingEmoji;
    [SerializeField] private Animator EnemyAnimator;

    public Transform PlayerChar;
    public Transform EnemyChar;
    public float EnemyPlayerDistance;
    public float EnemyCloseDistance;

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;

        boxCollider = GetComponent<BoxCollider>();
        cryingEmoji = Emoji.GetComponent<Animator>();
        EnemyAnimator = Enemy.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    // IEnumerator Start()
    //  {

    //  GetComponent<DestroyOnCollision>().enabled = false;

    //  yield return new WaitForSeconds(5);

    //  GetComponent<DestroyOnCollision>().enabled = true;

    //  }

    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<DestroyOnCollision>().isActiveAndEnabled)
        {
            if (collision.gameObject.Equals(Enemy))
            {

        // Code for when the Enemy collides with the Player
        
                cryingEmoji.SetBool("Collided", true);
                Debug.Log("WORKING");
                Destroy(Enemy);
                GameManager.instance.EndGame();

                // Code for making the screen shake at Collision with the enemy
                shakeScreen.Play(gameObject.transform.position);
                
                
                
            }

            if (collision.gameObject.CompareTag("Coin"))
            {
                
                CoinCounter++;
                Destroy(collision.gameObject);
                //print(CoinCounter);
               
            }
            
          
        }
       

       
    }

    private void OnTriggerEnter(Collider other)
    {
       //boxCollider.
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyPlayerDistance = Vector3.Distance(PlayerChar.position, EnemyChar.position);
        print(EnemyPlayerDistance);

        if (EnemyPlayerDistance <= EnemyCloseDistance)
        {
            
            shakeScreenLight.Play(gameObject.transform.position);

            if(EnemyAnimator!= null)
            {
                EnemyAnimator.SetLayerWeight(1, 1);
            }
            


          
                Emoji.SetActive(true);
                cryingEmoji.SetBool("Collided", true);
                // put your code that runs once here
                isDone = true;
          
            
            //CameraZoom.Play(gameObject.transform.position);


            //print("helloworld");
        }

        else
        {
            Emoji.SetActive(false);
            cryingEmoji.SetBool("Collided", false);
        }
    }
}
