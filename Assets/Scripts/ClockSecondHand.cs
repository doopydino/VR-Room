using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSecondHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Rotate the second hand to match the current time
        transform.Rotate(Vector3.right * System.DateTime.Now.Second * 6);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the second hand by 6 degrees every second
        transform.Rotate(Vector3.right * Time.deltaTime * 6);
    }
}
