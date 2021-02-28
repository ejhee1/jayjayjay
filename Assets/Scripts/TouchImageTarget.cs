using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

[RequireComponent(typeof(ARRaycastManager))]
public class TouchImageTarget : MonoBehaviour
{
    private ARRaycastManager arRaycastManager;

    [SerializeField]
    private Camera arCamera;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public GameObject myPrefab;
    // Start is called before the first frame update

    private Vector2 touchPosition = default;

    void Awake()
    {
        //dismissButton.onClick.AddListener(Dismiss);
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Image))
            {
                Pose hitPose = hits[0].pose;

                Instantiate(myPrefab, hitPose.position, Quaternion.identity);
            }
        }
    }
}
