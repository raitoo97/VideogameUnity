using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private Vector2 movVector = Vector2.zero;
    private float movementVelocity;
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
    private void OnMove()
    {
        movVector = InputMannager.instance.GetMovementPj();
        if (movVector == null) return;
        movVector.Normalize();
        rb?.MovePosition(rb.position + movVector * Time.deltaTime * movementVelocity);
        print(movVector);
    }
}
