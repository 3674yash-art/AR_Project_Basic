using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARCarPlacement : MonoBehaviour
{
    public GameObject carPrefab;

    private ARRaycastManager raycastManager;
    private GameObject spawnedCar;

    // Settings
    public float scaleAmount = 0.1f;
    public float rotationAmount = 20f;

    void Start()
    {
        raycastManager = FindAnyObjectByType<ARRaycastManager>();
    }

    void Update()
    {
        // Place the object automatically only once
        if (spawnedCar != null)
            return;

        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        if (raycastManager.Raycast(
            new Vector2(Screen.width / 2, Screen.height / 2),
            hits,
            TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;

            spawnedCar = Instantiate(
                carPrefab,
                hitPose.position,
                Quaternion.identity
            );
        }
    }

    // Increase object size
    public void IncreaseSize()
    {
        if (spawnedCar != null)
        {
            spawnedCar.transform.localScale +=
                Vector3.one * scaleAmount;
        }
    }

    // Decrease object size
    public void DecreaseSize()
    {
        if (spawnedCar != null)
        {
            Vector3 newScale =
                spawnedCar.transform.localScale -
                Vector3.one * scaleAmount;

            // Prevent the object from becoming too small
            if (newScale.x >= 0.1f)
            {
                spawnedCar.transform.localScale = newScale;
            }
        }
    }

    // Rotate object clockwise
    public void RotateRight()
    {
        if (spawnedCar != null)
        {
            spawnedCar.transform.Rotate(
                Vector3.up,
                rotationAmount
            );
        }
    }

    // Rotate object anti-clockwise
    public void RotateLeft()
    {
        if (spawnedCar != null)
        {
            spawnedCar.transform.Rotate(
                Vector3.up,
                -rotationAmount
            );
        }
    }

    // Change object colour
    public void ChangeColor()
    {
        if (spawnedCar != null)
        {
            Renderer[] renderers =
                spawnedCar.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers)
            {
                renderer.material.color =
                    Random.ColorHSV(
                        0f, 1f,
                        0.7f, 1f,
                        0.7f, 1f
                    );
            }
        }
    }
}