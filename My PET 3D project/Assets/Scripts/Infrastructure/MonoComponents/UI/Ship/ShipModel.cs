using System;
using UnityEngine;

namespace Assets.Scripts.UI.Ship
{
    [Serializable]
    public class ShipModel
    {
        [SerializeField] private GameObject _shipGameObject;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private GameObject _viewControl;
        [SerializeField] private GameObject _bigExposion;
        [SerializeField] private int _health;
        [SerializeField] private int _shields;
        [SerializeField] private int _speed;
        [SerializeField] private int _rotationSpeed;
        [SerializeField] private float _sensetive;
        [SerializeField] private bool _isPlayer;

        public GameObject Ship { get { return _shipGameObject; } }
        public int Speed { get { return _speed; } }
        public int RotationSpeed { get { return _rotationSpeed; } }
        public Rigidbody Rigidbody { get { return _rigidbody; } }
        public float Sensetive { get { return _sensetive; } }
        public GameObject ViewControl { get { return _viewControl; } }
        public bool IsPlayer { get { return _isPlayer;} }
        public int Health { get { return _health;} }
        public GameObject BigExplosion { get { return _bigExposion;} }
        public int Shields { get { return _shields;} }
    }
}
