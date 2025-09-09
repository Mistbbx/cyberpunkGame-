using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapMove : MonoBehaviour
{
    public int[,] map = { {1,1,1,1,1}, 
                          {1,0,0,0,1}, 
                          {1,0,1,1,1},
                          {1,0,0,0,1},
                          {1,1,1,1,1} 
    };
    public List<Vector2> dir = new List<Vector2>(4);
    public Vector2 loc =  new Vector2(1,1);
    public Image img;
    public Sprite[] imgList;
    public int index = 0;
    public int step = 0;
    public AudioSource s;
    public AudioClip[] move;
    public void Start()
    {
        dir.Add(new Vector2(0, -1));
        dir.Add(new Vector2(1, 0));
        dir.Add(new Vector2(0, 1));
        dir.Add(new Vector2(-1, 0));
 
        int temp = map[(int)(loc.x + dir[index].x), (int)(loc.y + dir[index].y)];
        switch (temp)
        {
            case 0:
                img.sprite = imgList[0];
                img.rectTransform.localScale = new Vector3(img.rectTransform.localScale.x * -1, 1, 1);
                break;
            case 1:
                img.sprite = imgList[1];
                break;
        }
    }
 
    // Start is called before the first frame update
    public void dungeonMove()
    {
        if(map[(int)(loc.x + dir[index].x), (int)(loc.y + dir[index].y)] == 0)
        {
            loc = loc + dir[index];
            int temp = map[(int)(loc.x + dir[index].x), (int)(loc.y + dir[index].y)];
            switch (temp)
            {
                case 0:   img.sprite = imgList[0];
                    img.rectTransform.localScale = new Vector3(img.rectTransform.localScale.x * -1, 1, 1);
                    break;
                case 1: img.sprite = imgList[1];
                    break;
            }

        }  
        if (step < move.Length - 1)
        {
            step++;
 
        }
        else
        {
            step = 0;
        }
        s.PlayOneShot(move[step]);
    }
 
    public void dungeonRightTurn()
    {
        if (index < dir.Count - 1)
            index++;
        else
            index = 0;
        int temp = map[(int)(loc.x + dir[index].x), (int)(loc.y + dir[index].y)];
        switch (temp)
        {
            case 0:
                img.sprite = imgList[0];
                img.rectTransform.localScale = new Vector3(img.rectTransform.localScale.x * -1, 1, 1);
                break;
            case 1:
                img.sprite = imgList[1];
                break;
        }
 
        if (step < move.Length - 1)
        {
            step++;
 
        }
        else
        {
            step = 0;
        }
        s.PlayOneShot(move[step]);
    }
 
    public void dungeonLeftTurn()
    {
        if (index > 0)
            index--;
        else
            index = dir.Count-1;
        int temp = map[(int)(loc.x + dir[index].x), (int)(loc.y + dir[index].y)];
        switch (temp)
        {
            case 0:
                img.sprite = imgList[0];
                img.rectTransform.localScale = new Vector3(img.rectTransform.localScale.x * -1, 1, 1);
                break;
            case 1:
                img.sprite = imgList[1];
                break;
        }
 
        if (step < move.Length - 1)
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