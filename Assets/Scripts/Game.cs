﻿using UnityEngine;

public class Game : MonoBehaviour
{
    private GameObject mainCamera;

    void Start()
    {
        Camera();
        Table();
        Nails();
        Ball();
    }

    private void Camera()
    {
        mainCamera = new GameObject();
        mainCamera.name = "Camera";
        mainCamera.transform.localPosition = new Vector3(10, 0, 0);
        mainCamera.transform.localEulerAngles = new Vector3(0, 270, 0);
        mainCamera.transform.localScale = new Vector3(1, 1, 1);
        mainCamera.AddComponent<Camera>();
    }

    private void Table()
    {
        gameObject.AddComponent<Board>();
    }

    private void Nails()
    {
        gameObject.AddComponent<Nails>();
    }

    private void Ball()
    {
        gameObject.AddComponent<Ball>();
    }
}
