using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.Plane
{
    public class PlanePlayerScript : MonoBehaviour
    {
        [SerializeField] private PlanePlayerModel _playerModel;
        private PlanePlayerControler _playerControler;


        void Start()
        {
            _playerControler = new PlanePlayerControler(_playerModel);
            _playerControler.Initialize();
        }

        private void Update()
        {
            _playerControler.Movement();
        }
    }
}