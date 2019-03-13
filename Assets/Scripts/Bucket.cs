using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public GameObject successCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with object: " + collision.gameObject.name);
        successCanvas.SetActive(true);
    }
}
