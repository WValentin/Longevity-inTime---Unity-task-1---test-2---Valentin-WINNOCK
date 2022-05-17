using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _trackedImage;

    private void Awake()
    {
        _trackedImage = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        _trackedImage.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        _trackedImage.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
