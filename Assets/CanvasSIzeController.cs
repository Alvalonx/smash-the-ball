using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSIzeController : MonoBehaviour
{
    public float targetWidth = 1080f;
    public float targetHeight = 1920f;

    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        RectTransform rectTransform = canvas.GetComponent<RectTransform>();

        float targetAspectRatio = targetWidth / targetHeight;

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float screenAspectRatio = screenWidth / screenHeight;

        float scaleFactor = 1f;
        if (screenAspectRatio > targetAspectRatio)
        {
            scaleFactor = screenWidth / targetWidth;
        }
        else
        {
            scaleFactor = screenHeight / targetHeight;
        }

        rectTransform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
    }
}
