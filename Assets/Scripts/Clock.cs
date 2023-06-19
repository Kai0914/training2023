using System;
using UnityEngine;

public class Clock : MonoBehaviour
{

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Awake()
    {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30 * DateTime.Now.Hour);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
    }
}