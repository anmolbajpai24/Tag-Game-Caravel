using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public static ChangeImage instance;

    public Image imageOnBlue;
    public Image imageOnRed;
    public Sprite tagged;
    public Sprite tag;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }
    // Start is called before the first frame update
    IEnumerator Start()
    {
        // new WaitForSeconds(10);
        imageOnRed.enabled = false;
        imageOnBlue.enabled = true;
        imageOnBlue.sprite = tag;
        yield return new WaitForSeconds(3f);

        imageOnBlue.enabled = false;
        imageOnRed.enabled = true;
        imageOnRed.sprite = tagged;

        //yield return new WaitForSeconds(1f);

        if (GameManager.instance.GameEnded)
        {

            imageOnRed.enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
