using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    public GameObject orbitPivot;
    public float orbitSpeed;

    // private Vector3 target = new Vector3(-0.4189999f, 0.209f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.RotateAround (orbitPivot.transform.position, new Vector3(0,1,0), orbitSpeed * Time.deltaTime);  
        // this.transform.RotateAround (orbitPivot.transform.position, Vector3.forward, orbitSpeed * Time.deltaTime);   
        // transform.RotateAround(target, Vector3.up, 30 * Time.deltaTime);

    }

    
}
