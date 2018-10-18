using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{
    public GameObject FallingBlock;
    public GameObject FastBlock;
    public GameObject FasterBlock;
    public GameObject FastestBlock;

    // Use this for initialization
    private void Start()
    {
        InvokeRepeating("SpawnBlock", 2.0f, 0.7f);
        InvokeRepeating("FastSpawnBlock", 10.0f, 0.6f);
        InvokeRepeating("FasterSpawnBlock", 15.0f, 0.5f);
        InvokeRepeating("FastestSpawnBlock", 20.0f, 0.4f);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void SpawnBlock()
    {
        GameObject instance = Instantiate(FallingBlock);
        instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 8.0f, 0f);
    }

    private void FastSpawnBlock()
    {
        GameObject instance = Instantiate(FastBlock);
        instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 8.0f, 0f);
    }

    private void FasterSpawnBlock()
    {
        GameObject instance = Instantiate(FasterBlock);
        instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 8.0f, 0f);
    }

    private void FastestSpawnBlock()
    {
        GameObject instance = Instantiate(FastestBlock);
        instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 8.0f, 0f);
    }
}