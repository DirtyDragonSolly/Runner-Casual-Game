using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _playerRigidBody;
    private Vector3 _forwardForce;
    [Range (500,5000)]public float forwardForce;
    private float horizontalMove;
    private float yRotateStabilization = -10;
    
    private void Start()
    {
        _playerRigidBody= GetComponent<Rigidbody>();
        _forwardForce = new Vector3(0, 0, -forwardForce);
    }

    private void Update()
    {
        horizontalMove = -Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        MoveForward();
        PlayerInput();
        Stabilization();
    }

    private void MoveForward()
    {        
        if(_playerRigidBody.velocity.z > -20)
            _playerRigidBody.AddForce(_forwardForce * Time.deltaTime);        
    }

    private void PlayerInput()
    {
        if (horizontalMove > 0 && _playerRigidBody.velocity.x < 7)
            _playerRigidBody.AddForce(horizontalMove * 2f, 0, 0, ForceMode.VelocityChange);
        if (horizontalMove < 0 && _playerRigidBody.velocity.x > -7)
            _playerRigidBody.AddForce(horizontalMove * 2f, 0, 0, ForceMode.VelocityChange);
    } 

    private void Stabilization()
    {
        if (transform.rotation.y != 0)
            transform.Rotate(0, yRotateStabilization * transform.rotation.y, 0);

        if (horizontalMove == 0)
        {
            if (_playerRigidBody.velocity.x < 0)
            {
                _playerRigidBody.AddForce((float)0.2, 0, 0, ForceMode.VelocityChange);
            }
            if (_playerRigidBody.velocity.x > 0)
            {
                _playerRigidBody.AddForce((float)-0.2, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}
