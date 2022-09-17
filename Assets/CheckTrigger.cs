using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    public static CheckTrigger instance;
        
    public GameObject Player;
    public bool isInTrigger = false;

    public void Awake()
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Target")
        {
            Debug.Log("Entered");
            isInTrigger = true;
            Pathfinding.AIDestinationSetter.instance.target = Player.transform;
        }
        
        
    }
}
