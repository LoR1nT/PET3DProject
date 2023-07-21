using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.Plane
{
    public class PlanePlayerControler
    {
        private PlanePlayerModel _playerModel;
        private GameObject _player;

        public PlanePlayerControler(PlanePlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        public void Initialize()
        {
            _player = _playerModel.PlanePlayer;
        }

        public void Movement()
        {
            _player.transform.position += Time.deltaTime * _player.transform.forward * Input.GetAxis("Vertical") * _playerModel.Speed;
            _player.transform.position += Time.deltaTime * _player.transform.right * Input.GetAxis("Horizontal") * _playerModel.Speed;
            float r = 0;
            if (Input.GetKey(KeyCode.Q))
            {
                r += _playerModel.RotationSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.E))
            {
                r -= _playerModel.RotationSpeed * Time.deltaTime;
            }

            float h = Input.GetAxis("Mouse X");
            float v = -Input.GetAxis("Mouse Y");



            _player.transform.Rotate(v, h, r);


        }
    }
}
