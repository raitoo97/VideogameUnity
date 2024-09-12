using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private Vector2 movVector = Vector2.zero;
    private float movementVelocity;
    private void Start()
    {
        movementVelocity = 10;
    }
    void Update()
    {
        OnMove();
    }
    private void OnMove()
    {
        movVector = InputMannager.instance.GetMovementPj();
        movVector.Normalize();
        this.transform.position += (Vector3)movVector * Time.deltaTime * movementVelocity;
    }
    public Vector2 MOVVECTOR { get { return movVector; } }
}
