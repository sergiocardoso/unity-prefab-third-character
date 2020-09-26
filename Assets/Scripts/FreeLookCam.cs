using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineFreeLook))]
public class FreeLookCam : MonoBehaviour
{
    private CinemachineFreeLook freeLookCam;
    public Joystick joyCamera;
    public float speed = 20f;


    void Start()
    {
        freeLookCam = GetComponent<CinemachineFreeLook>();
    }

    void Update()
    {
        freeLookCam.m_XAxis.m_InputAxisValue = -joyCamera.Horizontal * speed * Time.deltaTime;
    }
}
