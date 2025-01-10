using System.Collections;
using UnityEngine;

public class HellWorld : MonoBehaviour
{
    [SerializeField] GameObject Fire;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine (HellWorlds());
    }

    IEnumerator HellWorlds()
    {
        Debug.LogWarning("HELL WORLD :D");
        Instantiate(Fire, transform.position, Random.rotation);
        yield return new WaitForSeconds(Random.Range(1, 5));
        StartCoroutine (HellWorlds());
    }
}
