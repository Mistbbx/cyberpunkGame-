using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerGround : MonoBehaviour
{
    bool inDanger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inDanger) {

            charSheet.player.hp--;
        
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {

            inDanger = true;
        
        }
    }


    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            inDanger = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}


