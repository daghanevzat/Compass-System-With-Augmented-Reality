using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassTarget : MonoBehaviour
{
    // Calculates the directions and turn the own compass
    // This Script for Target

    public Vector3 NorthDirection;
    public Transform Target;
    public Quaternion MissionDirection;


    public Transform Northlayer;
    public Transform MissionLayer;

    public Transform MissionPlace;
    void Update()
    {
        ChangeNorthDirection();
        ChangeMissionDirection();
    }

    public void ChangeNorthDirection()
    {
        NorthDirection.z = Target.eulerAngles.y;
        Northlayer.localEulerAngles = NorthDirection;
    }

    public void ChangeMissionDirection()
    {
        Vector3 dir = transform.position - MissionPlace.position;
        MissionDirection = Quaternion.LookRotation(dir);

        MissionDirection.z = -MissionDirection.y;
        MissionDirection.x = 0;
        MissionDirection.y = 0;

        MissionLayer.localRotation = MissionDirection * Quaternion.Euler(NorthDirection);
    }
}
