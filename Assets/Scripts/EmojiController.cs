using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiController : MonoBehaviour
{
    public BoxCollider Slide1;
    // Start is called before the first frame update

    private void Awake()
    {
       Slide1 = GetComponent<BoxCollider>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(Slide1.)
    }

    private void OnTriggerEnter(Collider other)
    {
        print("YOYOYOYOYOYO");
    }


}
