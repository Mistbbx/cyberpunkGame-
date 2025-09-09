using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2000;
    public float jump = 6;
    private Rigidbody2D body;
    private BoxCollider2D box;
   
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, body.velocity.y);
        body.velocity = movement;

        Vector3 max = box.bounds.max;
        Vector3 min = box.bounds.min;
        Vector2 corner1 = new Vector2(max.x, min.y - 0.1f);
        Vector2 corner2 = new Vector2(min.x, min.y - 0.2f);
        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        bool grounded = false;

        if (hit != null)
            grounded = true;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            body.AddForce(Vector2.up * jump, ForceMode2D.Impulse);



        



    }
}
