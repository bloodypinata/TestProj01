using UnityEngine;
using System.Collections;

public class My2DCharacterController : MonoBehaviour
{

    public int moveSpeed;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb2d.velocity.y);
        rb2d.velocity = moveDir;

        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
