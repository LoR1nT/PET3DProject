using Assets.Scripts.UI.Ship;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.Controlers.MobControler.MobMovement.Implementation
{
    public class MobMovementController
    {
        private ShipModel _mobModel;
        private PlayerIndificator _target;
        private GameObject _mob;
        private Rigidbody _mobRigidbody;

        public MobMovementController(ShipModel mobModel)
        {
            _mobModel = mobModel;
            _mob = _mobModel.Ship;
            _mobRigidbody = _mob.GetComponent<Rigidbody>();
        }

        public void Movement()
        {
            UpdateTargetPosition();
        }

        private void UpdateTargetPosition()
        {
            _target = GameObject.FindObjectOfType<PlayerIndificator>();
            Debug.Log("FindTarget" + _target);
            if(_target.gameObject.layer == 6)
            {
                MobAIM();
            }
        }

        private void MobAIM()
        {
            Debug.Log("StartMoving");
            _mob.transform.LookAt(_target.transform.position);
            _mobRigidbody.velocity = _mob.transform.forward * _mobModel.Speed;

        }

    }
}
