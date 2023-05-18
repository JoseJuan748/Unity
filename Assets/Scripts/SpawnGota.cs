using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject gotaPrefab;
    [SerializeField] private Transform spawnLlave;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gotaPrefab, spawnLlave.position, spawnLlave.rotation);
        }
    }
}
