using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ENEMYCHECK : MonoBehaviour
{
    public GameObject enemy;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        if (enemy.activeInHierarchy)
        {
            text.text = "ENEMY IS ACTIVE";
        }

        else
            text.text = "ENEMY IS NOT ACTIVE";
    }
}
