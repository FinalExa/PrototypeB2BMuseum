using System;
using UnityEngine;

public class PossibleIntruder : MonoBehaviour
{
    public bool isIntruder;
    public static Action intruderFound;

    private void Awake()
    {
        ValidateTheIntruder.intruderSet += SetIntruder;
        isIntruder = false;
    }

    private void Start()
    {
    }

    public void CheckIfIsIntruder()
    {
        if (isIntruder == true)
        {
            intruderFound();
        }
        else
        {
            print("Innocent!");
        }
    }

    void SetIntruder()
    {
        isIntruder = true;
    }
}
