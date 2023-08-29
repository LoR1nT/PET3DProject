using Assets.Scripts.UI.Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.Controlers.MobControler.MobMovement.Implementation
{
    public class MobMovementController
    {
        private ShipModel _mobModel;
        private GameObject _mob;
        private float _planeSpeedBoost = 1;

        public MobMovementController(ShipModel mobModel)
        {
            _mobModel = mobModel;
            _mob = _mobModel.Ship;
        }

        public void Movement()
        {
            _mobModel.Rigidbody.velocity = _mobModel.Ship.transform.forward * _planeSpeedBoost * _mobModel.Speed;
        }

    }
}
