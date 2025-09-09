using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleMove : MonoBehaviour
{
    public Image img;
    public Sprite[] imgList;
    public int index;
    public int step= 0;
    public AudioSource s;
    public AudioClip[] move;
    // Start is called before the first frame update
    public void dungeonMove()
    {
        img.sprite = imgList[0];
        img.rectTransform.localScale = new Vector3(img.rectTransform.localScale.x*-1,1,1);
        if (step < move.Length-1)
        {
            step++;

        }
        else
        {
            step = 0;
        }
        s.PlayOneShot(move[step]);
    }

    public void dungeonTurn() {

        if (index < imgList.Length - 1)
            index++;
        else
            index = 0;
        img.sprite = imgList[index];
        if (step < move.Length-1)
        {
            step++;
            
        }
        else
        {
            step = 0;
        }
        s.PlayOneShot(move[step]);
    }
}
