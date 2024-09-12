using UnityEngine;
public class InputMannager : MonoBehaviour
{
    public static InputMannager instance;
    private PlayerControllerInputs playerControllerInputs;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void OnEnable()
    {
        playerControllerInputs = new PlayerControllerInputs();
        playerControllerInputs?.Enable();
    }
    private void OnDisable()
    {
        playerControllerInputs?.Disable();
        playerControllerInputs = null;
    }
    public Vector2 GetMovementPj()
    {
        return playerControllerInputs.Player.Move.ReadValue<Vector2>();
    }
}
