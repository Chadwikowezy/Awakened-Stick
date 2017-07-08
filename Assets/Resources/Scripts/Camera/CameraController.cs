using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed;

    public float xOffset;
    public float yOffset;
    public float zOffset;

    private Vector3 _movePos;
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }
    private void FixedUpdate()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        _movePos = _player.gameObject.transform.position;
        _movePos.x += xOffset;
        _movePos.y += yOffset;
        _movePos.z += zOffset;

        if ((_movePos - transform.position).magnitude > 0.1f)
            transform.position = Vector3.Lerp(transform.position, _movePos, moveSpeed * Time.fixedDeltaTime);
    }
}
