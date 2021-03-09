using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleFollow : MonoBehaviour
{
    public GameObject toFollow;
    public float maxDistanceToFollow = 5f;
    public float maxVelocity = 2f;
    private Vector3 startPosition;
    public bool backToStartPosition = false;
    private void Start()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
        Vector3 tempDist = toFollow.transform.position - transform.position;
        //alternativa para o vector3.distance nativo da unity

        if (Vector3.Distance(toFollow.transform.position, transform.position) < maxDistanceToFollow && Vector3.Distance(toFollow.transform.position, transform.position) > 1.15f)
        {
            transform.position = Vector3.MoveTowards(transform.position, toFollow.transform.position, maxVelocity * Time.deltaTime);
        }
        if (backToStartPosition && Vector3.Distance(toFollow.transform.position, transform.position) > maxDistanceToFollow)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, maxVelocity * Time.deltaTime);
        }
    }
}
