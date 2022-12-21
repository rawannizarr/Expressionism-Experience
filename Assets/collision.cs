using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    Vector3 intialposition = new Vector3();
    private void Start()
    {
        intialposition = transform.position;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("painting"))
        {
            transform.position = intialposition;

        }
        if (other.gameObject.CompareTag("this painting explains frida's"))
        {
            Debug.Log("look its a painting");
            Time.timeScale = 0;
        }
    }
}
