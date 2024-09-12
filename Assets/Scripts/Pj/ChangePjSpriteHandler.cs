using UnityEngine;
public enum POSITION
{
    UP, DOWN, LEFT, RIGHT
}
public class ChangePjSpriteHandler : MonoBehaviour
{
    public static ChangePjSpriteHandler Instance;
    [SerializeField]private POSITION positionSprite;
    private PlayerController spritePj;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        spritePj = GameObject.FindObjectOfType<PlayerController>();
        spriteRenderer = spritePj.gameObject.GetComponent<SpriteRenderer>();
        positionSprite = POSITION.UP;
    }
    private void Update()
    {
        UpdateRotationPos();
    }
    private void UpdateRotationPos()
    {
        switch (positionSprite)
        {
            case POSITION.UP:
                spriteRenderer.flipY = false;
                break;
            case POSITION.DOWN:
                spriteRenderer.flipY = true;
                break;
            case POSITION.LEFT:
                spriteRenderer.flipX = true;
                break;
            case POSITION.RIGHT:
                spriteRenderer.flipX = false;
                break;
        }
    }
    public void ChangePjRotation(POSITION currentPoistion)
    {
        positionSprite = currentPoistion;
    }
}
