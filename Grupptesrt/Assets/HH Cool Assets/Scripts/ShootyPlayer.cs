using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootyPlayer : MonoBehaviour
{
    [SerializeField] List<GameObject> projectiles;
    [SerializeField] float acceleration;
    [SerializeField] float reloadCooldown;
    float reloadCooldownOrg;
    int playerState;

    Vector2 playerInput;
    Rigidbody2D playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reloadCooldownOrg = reloadCooldown;
        playerState = 0;
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementControls();
        reloadCooldown -= Time.deltaTime;
        if(reloadCooldown < 0 )
        {
            reloadCooldown = 0;
        }

        if (Input.GetKeyDown(KeyCode.Q) && reloadCooldown == 0)
        {
            Instantiate(projectiles[0], transform.position, Quaternion.identity);
            reloadCooldown = reloadCooldownOrg;
        }
    }
    void MovementControls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerState = 1;
            playerRB.linearVelocityX = -acceleration;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerState = 1;
            playerRB.linearVelocityX = acceleration;
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerState = 1;
            playerRB.linearVelocityY = acceleration;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerState = 1;
            playerRB.linearVelocityY = -acceleration;

        }
        if (!Input.anyKey)
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
            case 2:
                playerRB.linearVelocityX = 0;
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Fire"))
        {
            Debug.Log("AAAAAAHH");
        }
    }
}
