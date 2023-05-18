using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumController : MonoBehaviour
{
    public GameObject podium; 

    public void lowerPlatform()
    {
        podium.transform.position = new Vector3(transform.position.x, transform.position.y-0.1f,transform.position.z);
        
    }

    public void elevatePlatform()
    {
        podium.transform.position = new Vector3(transform.position.x, transform.position.y+0.1f,transform.position.z);
    }

}
