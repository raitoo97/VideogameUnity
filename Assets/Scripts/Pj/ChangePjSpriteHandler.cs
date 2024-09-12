using UnityEngine;
public enum POSITION
{
    UP, DOWN, LEFT, RIGHT
}
public class ChangePjSpriteHandler : MonoBehaviour
{
    public static ChangePjSpriteHandler Instance;
    private POSITION positionSprite;
    private PlayerController spritePj;
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
        positionSprite = POSITION.UP;
        print(spritePj?.name);
    }
    private void Update()
    {
        UpdateRotationPos();
    }
    public void UpdateRotationPos()
    {
        switch (positionSprite)
        {
            case POSITION.UP:
                spritePj.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case POSITION.DOWN:
                spritePj.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case POSITION.LEFT:
                spritePj.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case POSITION.RIGHT:
                spritePj.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
        }
    }
    public void ChangePjRotation(POSITION currentPoistion)
    {
        positionSprite = currentPoistion;
    }
}
