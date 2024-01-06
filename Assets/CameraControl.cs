using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    private void Start()
    {
        gameObject.tag = "MainCamera";
        GameObject mainCamera = GameObject.FindWithTag("MainCamera");
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Camera.main.orthographicSize = screenSize.y / 2;
        Camera.main.orthographicSize = mainCamera.GetComponent<Camera>().orthographicSize;
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }
}
