using System;
using UnityEngine;

public class ValidateTheIntruder : MonoBehaviour
{
    public static Action intruderSet;
    public void ValidateIntruder()
    {
        intruderSet();
    }
}
