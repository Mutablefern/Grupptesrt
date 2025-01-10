using UnityEngine;

public class Bullet_1 : MonoBehaviour
{
    [SerializeField] Rigidbody2D projectileRB;
    [SerializeField] Vector3 acceleration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        projectileRB.linearVelocityY = acceleration.y;
    }
}
