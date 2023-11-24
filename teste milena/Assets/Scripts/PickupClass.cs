using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private LayerMask PickupLayer;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private float ThrowingForce;
    [SerializeField] private float PickupRange;
    [SerializeField] private Transform Hand;


    private Rigidbody CurrentObjectRigidBody;
    private Collider CurrentObjectCollider;

    void Update()
    {

     if (Input.GetKeyDown(KeyCode.E))
     {
            Ray Pickupray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);

            if (Physics.Raycast(Pickupray, out RaycastHit hitInfo, PickupRange, PickupLayer)) ;
            {
                if (CurrentObjectRigidBody)
                {
                    CurrentObjectRigidBody.isKinematic = false;
                    CurrentObjectCollider.enabled = true;

                    CurrentObjectRigidBody = hitInfo.rigidbody;
                    CurrentObjectCollider = hitInfo.collider;

                    CurrentObjectRigidBody.isKinematic = true;
                    CurrentObjectCollider.enabled = false;

                }
                else
                {
                    CurrentObjectRigidBody = hitInfo.rigidbody;
                    CurrentObjectCollider = hitInfo.collider;

                    CurrentObjectRigidBody.isKinematic = true;
                    CurrentObjectCollider.enabled = false;
                }
                return;
            }
            if (CurrentObjectRigidBody)
            {
                CurrentObjectRigidBody.isKinematic = false;
                CurrentObjectCollider.enabled = true;

                CurrentObjectRigidBody = null;
                CurrentObjectCollider = null;

                

            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            CurrentObjectRigidBody.isKinematic = false;
            CurrentObjectCollider.enabled = true;

            CurrentObjectRigidBody.AddForce(PlayerCamera.transform.forward * ThrowingForce, ForceMode.Impulse);

            CurrentObjectRigidBody = null;
            CurrentObjectCollider = null;
        }

        if(CurrentObjectRigidBody)
        {
            CurrentObjectRigidBody.position = Hand.position;
            CurrentObjectRigidBody.rotation = Hand.rotation;
        }
     
    }
}
