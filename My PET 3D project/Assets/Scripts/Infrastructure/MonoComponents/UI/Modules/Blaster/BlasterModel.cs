using System;
using UnityEngine;

namespace Assets.Scripts.UI.Modules.Blaster
{
    [Serializable]
    public class BlasterModel
    {
        [SerializeField] private GameObject _blasterFirePoint;
        [SerializeField] private BlasterBulletScript _bulletPrefab;
        [SerializeField] private ParticleSystem _particleSystem;
        [SerializeField] private float _bulletSpeed;
        [SerializeField] private bool _isPlayer;
        [SerializeField] private int _fireRate;

        public BlasterBulletScript BulletPrefab { get { return _bulletPrefab; } }
        public GameObject BlasterFirePoint { get { return _blasterFirePoint; } }
        public ParticleSystem ParticleSystem { get { return _particleSystem; } }
        public float BulletSpeed { get { return _bulletSpeed; } }
        public bool IsPlayer { get { return _isPlayer;} }
        public int FireRate { get { return _fireRate;} }
    }
}
