using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPrefab;
    [SerializeField] float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, 6f), 8);
            Instantiate(targetPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
    