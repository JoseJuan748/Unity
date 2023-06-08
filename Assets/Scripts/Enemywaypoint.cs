using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using UnityEngine;

public class Enemywaypoint : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    int index = 0;
    Vector3 dir;
  
    void Update()
    {
        if (waypoints.Length == 0) return;

        dir = (waypoints[index].position - transform.position).normalized;
        transform.Translate(dir * 4 * Time.deltaTime);

        if (Vector3.Distance(waypoints[index].position, transform.position) <= 1f)
        {
            index = (index + 1) % waypoints.Length;
        }
    }

    void Start()
    {
        print(waypoints.Length);
    }
}
