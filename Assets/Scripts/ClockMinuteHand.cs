using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMinuteHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Rotate the minute hand to match the current time
        transform.Rotate(Vector3.right * System.DateTime.Now.Minute * 6);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the minute hand by 1 degrees every 10 seconds
        transform.Rotate(Vector3.right * Time.deltaTime / 10);
    }
}
