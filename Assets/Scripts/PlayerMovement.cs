using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed_multiplier = 5f;
    void Update()
    {
        Vector2 movement = new Vector2(0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            movement += new Vector2(0, 1);
            
        }
        if(Keyboard.current.sKey.isPressed)
        {
            movement += new Vector2(0, -1);
        }
        if(Keyboard.current.aKey.isPressed)
        {
            movement += new Vector2(-1, 0);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            movement += new Vector2(1, 0);
        }
        movement = movement.normalized;
        transform.Translate(movement * Speed_multiplier * Time.deltaTime);
    }

    
}
