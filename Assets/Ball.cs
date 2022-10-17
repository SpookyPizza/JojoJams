using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public GameObject starPlatinum;
    public GameObject theWorld;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "StarPlatinum")
        {
            float difference = this.transform.position.y - starPlatinum.transform.position.y;
            float angle = difference * (Mathf.PI / (1.25f * 2.7f));
            rb.velocity = new Vector2(Mathf.Cos(angle) * speed, Mathf.Sin(angle) * speed);
        }
        if (col.gameObject.tag == "TheWorld")
        {
            float difference = this.transform.position.y - theWorld.transform.position.y;
            float angle = difference * (Mathf.PI / (1.25f * 2.7f));
            rb.velocity = new Vector2(-1 * Mathf.Cos(angle) * speed, Mathf.Sin(angle) * speed);
        }
        if (col.gameObject.tag == "Wall")
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
    }
}
