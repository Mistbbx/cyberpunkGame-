using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class outlineHover : MonoBehaviour
{
    public Material normal;
    public Material hover;
    public AudioClip melee;
    public AudioClip bow;
    public AudioSource s;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Image>().material = normal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPointerClick(int i) {
        Debug.Log("Click!");
        if (i == 0)
            s.PlayOneShot(melee);
        else if (i == 1)
            s.PlayOneShot(bow);
    
    }


    public void onPointerEnter() {
        this.gameObject.GetComponent<Image>().material = hover;
    }

    public void onPointerExit() {

        this.gameObject.GetComponent<Image>().material = normal;
    }

}
