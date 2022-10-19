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
        float angle = AngleBetweenPoints(this.transform.position, new Vector2(rb.velocity.x, rb.velocity.y) *2);
        this.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle + 180));
    }

    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
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
        if (col.gameObject.tag == "GoalJotaro")
        {
            this.transform.position = new Vector2(0, 0);
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(-speed / 1.5f, 0);
        }
        if (col.gameObject.tag == "GoalDio")
        {
            this.transform.position = new Vector2(0, 0);
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(speed / 1.5f, 0);
        }
    }

    
}
