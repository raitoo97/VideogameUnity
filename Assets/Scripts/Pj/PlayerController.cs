using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private Vector2 movVector = Vector2.zero;
    private int movementVelocity;
    private Rigidbody2D rb;
    private void Start()
    {
        movementVelocity = 10;
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        OnMove();
    }
    private void Update()
    {
        RotateSprite();
    }
    private void OnMove()
    {
        movVector = InputMannager.instance.GetMovementPj();
        if (movVector == null) return;
        movVector.Normalize();
        rb?.MovePosition(rb.position + movVector * Time.fixedDeltaTime * movementVelocity);
    }
    private void RotateSprite()
    {
        if (movVector.x == 0 && movVector.y == 1)
        {
            ChangePjSpriteHandler.Instance.ChangePjRotation(POSITION.UP);
        }
        if (movVector.x == 0 && movVector.y == -1)
        {
            ChangePjSpriteHandler.Instance.ChangePjRotation(POSITION.DOWN);
        }
        if (movVector.x == 1 && movVector.y == 0)
        {
            ChangePjSpriteHandler.Instance.ChangePjRotation(POSITION.RIGHT);
        }
        if (movVector.x == -1 && movVector.y == 0)
        {
            ChangePjSpriteHandler.Instance.ChangePjRotation(POSITION.LEFT);
        }
    }
}
