using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Himanshu : MonoBehaviour
{
    public GameObject carPrefab;

    private ARRaycastManager raycastManager;
    private GameObject spawnedCar;

    void Start()
    {
        raycastManager = FindAnyObjectByType<ARRaycastManager>();
    }

    void Update()
    {
        if (spawnedCar != null)
            return;

        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        // Detect a horizontal plane automatically
        if (raycastManager.Raycast(
            new Vector2(Screen.width / 2, Screen.height / 2),
            hits,
            TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;

            // Spawn the prefab automatically on the detected plane
            spawnedCar = Instantiate(
                carPrefab,
                hitPose.position,
                Quaternion.identity
            );
        }
    }
}