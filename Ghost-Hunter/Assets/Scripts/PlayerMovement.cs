using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform myTransform;
    private Rigidbody2D myRigidbody;
    private SpriteRenderer mySpriteRenderer;

    public float speed = 2f;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Code inspired by maths ;)
        SetVelocity(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        SetSprite();
    }

    private void SetVelocity(Vector2 velocity)
    {
        // The speed must be normalized to avoid diagonal movements from being faster than straight ones
        myRigidbody.velocity = velocity.normalized * speed;
    }

    private void SetSprite()
    {
        // Get the angle of the player based on his velocity
        // Atan2 gives the result in radians, so we need to convert it to degrees
        float angle = Mathf.Rad2Deg * Mathf.Atan2(myRigidbody.velocity.y, myRigidbody.velocity.x);
        // Pick the correct sprite based on the angle
        // TODO Replace nulls with sprites
        mySpriteRenderer.sprite = angle switch
        {
            // Going to the left
            float x when x >= -135 && x < -45 => null,
            // Going upward
            float x when x >= -45 && x < 45 => null,
            // Going to the right
            float x when x >= 45 && x < 135 => null,
            // Going downward
            _ => null,
        };
    }
}
