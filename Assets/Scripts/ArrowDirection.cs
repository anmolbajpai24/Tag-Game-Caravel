using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowDirection : MonoBehaviour
{
    public GameObject target;
    public Transform targetTransform;

    public GameObject Emoji;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // targetTransform = target.transform.position.x;
        Vector3 targetPos = target.transform.position;

        //Vector3

        targetPos.y = transform.position.y;
        transform.DOLookAt(targetPos,0.1f);


        

      //  Quaternion.LookRotation(Vector3.);
    }
}
