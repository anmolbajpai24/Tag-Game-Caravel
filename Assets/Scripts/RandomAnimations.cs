using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimations : MonoBehaviour
{
    private Animator anim;
    public GameObject flikeringLights;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while(true)
        {
            yield return new WaitForSeconds(1);

            anim.SetInteger(("JumpIndex"),Random.Range(1, 4));

            flikeringLights.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            flikeringLights.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
