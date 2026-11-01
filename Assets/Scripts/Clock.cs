using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float k_DegreesPerHour = 30f;
    const float k_DegreesPerMinute = 6f;
    const float k_DegreesPerSecond = 6f;

    [SerializeField]
    Transform hoursTransform, minutesTransform, secondsTransform;

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, 0f, -time.Hour * k_DegreesPerHour);
        minutesTransform.localRotation = Quaternion.Euler(0f, 0f, -time.Minute * k_DegreesPerMinute);
        secondsTransform.localRotation = Quaternion.Euler(0f, 0f, -time.Second * k_DegreesPerSecond);
    }
}
