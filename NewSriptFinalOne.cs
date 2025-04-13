using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSriptFinalOne : MonoBehaviour
{
    public float RotationSpeed = 5f;
    public float maxXRot = 0;
    public float minXRot = -88;
    public float maxYRot = 45;
    public float minYRot = -45;
    public float rotZ = 0;

    private Transform localTrans;
    void Start()
    {
        localTrans = GetComponent<Transform>();
    }

    void Update()
    {

        LimiteXRot();
    }

    private void LimiteXRot()
    {

        Vector3 playerEulerAngles = localTrans.rotation.eulerAngles;

        playerEulerAngles.x = (playerEulerAngles.x > 180) ? playerEulerAngles.x - 360 : playerEulerAngles.x;
        playerEulerAngles.x = Mathf.Clamp(playerEulerAngles.x, minXRot, maxXRot);
        playerEulerAngles.y = (playerEulerAngles.y > 180) ? playerEulerAngles.y - 360 : playerEulerAngles.y;
        playerEulerAngles.y = Mathf.Clamp(playerEulerAngles.y, minYRot, maxYRot);
        playerEulerAngles.z = Mathf.Clamp(playerEulerAngles.y, rotZ, rotZ);

        localTrans.rotation = Quaternion.Euler(playerEulerAngles);
    }
}