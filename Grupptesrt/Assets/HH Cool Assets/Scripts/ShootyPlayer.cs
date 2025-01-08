using System.Collections.Generic;
using UnityEngine;

public class ShootyPlayer : MonoBehaviour
{
    [SerializeField] List<GameObject> projectiles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectiles[0], transform.position, Quaternion.identity);  
        }
    }
}
