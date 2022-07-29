using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHourHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Rotate the hour hand to match the current time
        transform.Rotate(Vector3.right * System.DateTime.Now.Hour * 30);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the hour hand by 1 degrees every 120 seconds
        transform.Rotate(Vector3.right * Time.deltaTime / 120);
    }
}
