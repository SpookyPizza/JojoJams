using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWorldControl : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            audioSource.PlayOneShot(sound);
        }
    }
    private Rigidbody2D rb;
    private Transform transform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4)
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
        }
        if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
    }
}
