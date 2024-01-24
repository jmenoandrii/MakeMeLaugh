using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPickingUp : MonoBehaviour
{
    [SerializeField]
    private bool _equipped = false;
    [SerializeField]
    private Transform _cameraTransform;
    [SerializeField]
    private float _lerpSpeed;
    [SerializeField]
    private GameObject _objectGrabPoint;

    private GameObject _equippedItem;
    private Rigidbody _equippedItemRb;

    public void Drop()
    {
        if (_equipped)
        {
            _equipped = false;
            _equippedItemRb.useGravity = true;
            _equippedItemRb.velocity = Vector3.zero;
        }
    }

    public void PickUp(GameObject item)
    {
        if (!_equipped)
        {
            _equipped = true;
            _equippedItem = item;

            _objectGrabPoint.transform.position = _equippedItem.transform.position;

            _equippedItemRb = item.GetComponent<Rigidbody>();
            _equippedItemRb.useGravity = false;
        }
    }

    private void Update()
    {
        if (_equipped)
        {
            Vector3 newPosition = Vector3.Lerp(_equippedItem.transform.position, _objectGrabPoint.transform.position, Time.deltaTime * _lerpSpeed);
            _equippedItemRb.MovePosition(newPosition);
        }
    }
}
