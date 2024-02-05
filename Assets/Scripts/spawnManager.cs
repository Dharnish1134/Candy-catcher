using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    [SerializeField]
    private float xMax;
    [SerializeField] float Wait;

    public GameObject[] candies;

    public static spawnManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void spawn()
    {
        int index = Random.Range(0, candies.Length);
        float randomX = Random.Range(-xMax, xMax);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(candies[index], randomPos, transform.rotation);

    }


    private IEnumerator spawnCandies()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(Wait);
        }
        
    }

    public void StartSpawning()
    {
        StartCoroutine("spawnCandies");
    }

    public void StopSpawning()
    {
        StopCoroutine("spawnCandies");
    }

    private void Start()
    {
        StartSpawning();
    }

}
