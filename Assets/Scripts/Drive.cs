using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Drive : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private float _rotationSpeed = 300f;
    private float _moveInput;

    PhotonView view;


    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
            {
                _moveInput = Input.GetAxisRaw("Horizontal");
            }    

    }

    private void FixedUpdate()
    {
        if (view.IsMine)
        {
            _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
            _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
            _carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
        }

    }
}
