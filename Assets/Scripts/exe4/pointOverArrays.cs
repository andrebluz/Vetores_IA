using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointOverArrays : MonoBehaviour
{
    public List<GameObject> points;
    public float maxVelocity = 5f;
    private int id = 0;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[id].transform.position, maxVelocity * Time.deltaTime);
        print(points.Count);
        if (Vector3.Distance(points[id].transform.position, transform.position) < 1f)
        {
            //correção manual com -1 em poins.Count pois o inicio da list é 0 e não 1
            if(id < (points.Count - 1))
            {
                id++;
            }
            else
            {
                id--;
            }
        }
    }
    
}
