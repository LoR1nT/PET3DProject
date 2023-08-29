using Assets.Scripts.UI.Ship;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.Controlers.PlayerMovement.Implementation
{
    public class PlayerMovementControler
    {
        private ShipModel _playerModel;
        private GameObject _player;
        private GameObject _cameraControl;
        private float _planeSpeedBoost = 1;

        public PlayerMovementControler(ShipModel playerModel)
        {
            _playerModel = playerModel;
            _player = _playerModel.Ship;
            _cameraControl = _playerModel.ViewControl;
        }

        public void Movement()
        {
            if (Input.GetKey(KeyCode.W))
            {
                _planeSpeedBoost = 4;
            }

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            {
                _planeSpeedBoost = 10;
            }

            _playerModel.Rigidbody.velocity = _playerModel.Ship.transform.forward * _playerModel.Speed * _planeSpeedBoost;   
            
            if (CameraRotation())
            {
                Rotation();
            }

            _planeSpeedBoost = 1;
        }
        private void Rotation()
        {
            float rotation = 0;
            float h = Input.GetAxis("Mouse X") * _playerModel.Sensetive;
            float v = -Input.GetAxis("Mouse Y") * _playerModel.Sensetive;

            if (Input.GetKey(KeyCode.Q))
            {
                rotation += _playerModel.RotationSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.E))
            {
                rotation -= _playerModel.RotationSpeed * Time.deltaTime;
            }

            _player.transform.Rotate(v, h, rotation);
        }

        private bool CameraRotation()
        {
            float h = Input.GetAxis("Mouse X");
            float v = -Input.GetAxis("Mouse Y");

            if (Input.GetKey(KeyCode.C))
            {
                _cameraControl.transform.Rotate(v, h, 0);
                return false;
            }
            else
            {
                _cameraControl.transform.rotation = _player.transform.rotation;
                return true;
            }
        }

    }
}
