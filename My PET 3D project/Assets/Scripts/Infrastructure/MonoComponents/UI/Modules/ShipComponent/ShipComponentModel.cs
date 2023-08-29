using Assets.Scripts.UI.Ship;
using System;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.ShipComponent
{
    [Serializable]
    public class ShipComponentModel
    {
        [SerializeField] private GameObject _shipComponent;
        [SerializeField] private int _health;
        [SerializeField] private ShipScript _shipMainScript;

        public GameObject ShipComponent { get { return _shipComponent; } }
        public int Heath { get { return _health; } }
        public ShipScript ShipMainScript { get { return _shipMainScript; } }

    }
}
