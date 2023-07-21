using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.Plane
{
    [Serializable]
    public class PlanePlayerModel
    {
        [SerializeField] GameObject _planePlayerGameObject;
        [SerializeField] int _speed;
        [SerializeField] int _rotationSpeed;

        public GameObject PlanePlayer { get { return _planePlayerGameObject; } }
        public int Speed { get { return _speed; } }
        public int RotationSpeed { get { return _rotationSpeed; } }

    }
}
