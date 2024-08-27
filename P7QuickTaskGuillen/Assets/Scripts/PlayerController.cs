using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float canWeGetMuchHigher;
    private float horizontal;
    public float speed = 1;
    public GameOverScreen GameOverScreen;
    bool crown = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, canWeGetMuchHigher));
        }
        transform.Translate (new Vector2(horizontal * speed * Time.deltaTime, 0f));
    }
}
