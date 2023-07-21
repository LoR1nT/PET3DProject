using System;
using UnityEngine;

namespace Assets.Scripts.UI.Modules.Blaster
{
    [Serializable]
    public class BlasterModel
    {
        [SerializeField] private GameObject _blasterFirePoint;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private float _bulletSpeed;

        public GameObject BulletPrefab { get { return _bulletPrefab; } }
        public GameObject BlasterFirePoint { get { return _blasterFirePoint; } }
        public float BulletSpeed { get { return _bulletSpeed; } }
    }
}
