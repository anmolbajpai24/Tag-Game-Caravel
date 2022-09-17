using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;
    
    public NavMeshAgent enemy;

    public Transform PlayerPos;

    public GameObject Player;

    [SerializeField]  private Rigidbody rigidbody;

   // [SerializeField] private float jumpAdd;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
        rigidbody = GetComponent<Rigidbody>();

        //   GameObject.Find("Player").GetComponent<SimpleSampleCharacterControl>().
    }
    void Start()
    {
        PlayerPos = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerPos.position);
    }

    public void EnemyJump()
    {
        Debug.Log("Enemy jump");
      //  rigidbody.AddForce(Vector3.up * jumpAdd, ForceMode.VelocityChange);
    }
}
