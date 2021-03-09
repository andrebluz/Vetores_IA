using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            this.gameObject.transform.position += new Vector3(0.01f * Input.GetAxis("Horizontal"), 0, 0.01f * Input.GetAxis("Vertical"));
        }
        
    }

}
