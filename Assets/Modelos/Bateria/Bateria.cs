using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{

    public GameObject Linterna;
    public float bateria;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Linterna.GetComponent<Linterna>().cantBateria += bateria;
            Destroy(gameObject);
        }
    }
}

