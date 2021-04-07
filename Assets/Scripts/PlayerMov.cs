
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField]
    public float speed;
    private Vector2 direction;
    void Start()
    {
        direction = Vector2.up;
    }
    void Update()
    {
        GetInput();
        MOVE();
    }
    public void MOVE()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }
}