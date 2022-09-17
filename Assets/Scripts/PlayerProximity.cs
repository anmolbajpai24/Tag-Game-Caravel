using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProximity : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Ray straightRay = new Ray(transform.position, Vector3.forward);

        if(Physics.Raycast(straightRay, out hit))
        {
           // print(hit.distance);
          //  Debug.DrawRay(transform.position, Vector3.forward);
           //+* Debug.Log("HITTING");
        }
    }
}
