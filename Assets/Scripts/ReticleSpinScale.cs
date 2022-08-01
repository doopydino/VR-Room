using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleSpinScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Match rotation of the reticle to the rotation of other reticles
        transform.Rotate(Vector3.up * System.DateTime.Now.Second * 20);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the reticle by 20 degrees every second
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }
}
