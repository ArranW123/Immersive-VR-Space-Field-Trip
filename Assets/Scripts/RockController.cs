using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public ParticleSystem dust;
    public Collider rockCollider;
    bool grounded = false;


    // Start is called before the first frame update
    void Start()
    {
        rockCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    
    void OnCollisionEnter(Collision other) {
        dust.Play();        
    }   

    void OnCollisionExit(Collision other) {
        dust.Stop();
    }

    void Update()
    {

    }

    void CreateDust()
    {
    }


}
