using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootyPlayer : MonoBehaviour
{
    [SerializeField] List<GameObject> projectiles;
    [SerializeField] float acceleration;
    int playerState;

    Vector2 playerInput;
    Rigidbody2D playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerState = 0;
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementControls();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectiles[0], transform.position, Quaternion.identity);
        }
    }
    void MovementControls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerState = 1;
            playerRB.linearVelocityX = -acceleration;
        }
        else if
        (Input.GetKey(KeyCode.D))
        {
            playerState = 1;
            playerRB.linearVelocityX = acceleration;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            playerState = 1;
            playerRB.linearVelocityY = acceleration;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerState = 1;
            playerRB.linearVelocityY = -acceleration;
            
        }
        else
        {
            playerState = 0;
        }

    }
    private void FixedUpdate()
    {
        switch (playerState)
        {
            case 0:
                playerRB.linearVelocity = new Vector2(0, 0);
                break;

            case 1:

                break;
        }
    }
}
