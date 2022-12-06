using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stapler : MonoBehaviour
{
    //Variables
    public GameObject staple;
    public Transform launchPoint;
public void ShootStaple()
    {
        Instantiate(staple, launchPoint.position, launchPoint.rotation);
    }
}
