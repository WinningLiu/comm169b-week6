using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupClass : MonoBehaviour
{
    [SerializeField] private LayerMask PickupLayer;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private float PickupRange;

    private Rigidbody CurrentObjectRigidbody;
    private Collider CurrentObjectCollider;

    // Update is called once per frame
    void Update()
    {

        Ray Pickupray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);

        if (Physics.Raycast(Pickupray, out RaycastHit hitInfo, PickupRange, PickupLayer))
        {
            if (CurrentObjectRigidbody)
            {
                CurrentObjectRigidbody.isKinematic = false;
                CurrentObjectCollider.enabled = true;

                CurrentObjectRigidbody = hitInfo.rigidbody;
                CurrentObjectCollider = hitInfo.collider;

                CurrentObjectRigidbody.isKinematic = true;
                CurrentObjectCollider.enabled = false;
            }
            else
            {
                CurrentObjectRigidbody = hitInfo.rigidbody;
                CurrentObjectCollider = hitInfo.collider;

                CurrentObjectRigidbody.isKinematic = true;
                CurrentObjectCollider.enabled = false;
            }
        }
    }
}
