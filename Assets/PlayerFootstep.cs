using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootstep : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FootstepPlay()
    {
        AudioManager.instance.PlayFootStep();
        Debug.Log("FOOTSTEP WORKING");
    }
}
