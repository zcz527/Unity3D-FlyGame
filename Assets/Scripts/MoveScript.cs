using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    private Rigidbody2D rigidbody2D;
    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }

    void FixedUpdate()
    {
        if (rigidbody2D == null)
        {
            rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        }
        rigidbody2D.velocity = movement;
    }
}
