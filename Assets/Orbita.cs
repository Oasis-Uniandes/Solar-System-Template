using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform eje;
    public float velocidad;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(eje.position, Vector3.up, velocidad * Time.deltaTime);
    }
}
