using Assets.Scripts.Infrastructure.Controlers.MobControler.MobMovement.Implementation;
using Assets.Scripts.Infrastructure.Controlers.PlayerMovement.Implementation;
using UnityEngine;

namespace Assets.Scripts.UI.Ship
{
    public class ShipControler
    {
        private ShipModel _shipModel;
        private PlayerMovementControler _playerMovementControler;
        private MobMovementController _mobMovementController;
        public int Health = 0;
        public int Shield = 0;

        public ShipControler(ShipModel playerModel)
        {
            _shipModel = playerModel;
        }

        public void Initialize()
        {
            Health = _shipModel.Health;
            Shield = _shipModel.Shields;
        }

        public void Movement()
        {
            if (_shipModel.IsPlayer)
            {
                _playerMovementControler = new PlayerMovementControler(_shipModel);
                _playerMovementControler.Movement();
            }
            else
            {
                _mobMovementController = new MobMovementController(_shipModel);
                _mobMovementController.Movement();
            }
        }

        public void DamageRegistration(int damage)
        {
            if(Shield > 0)
            {
                Shield -= damage;
            }
            else
                Health -= damage; 
        }

        public void IsDestroedShip()
        {
            if (Health <= 0)
            {
                Object.Destroy(_shipModel.Ship);


                GameObject explosion = Object.Instantiate(_shipModel.BigExplosion, _shipModel.Ship.transform.position, _shipModel.Ship.transform.rotation);
                Object.Destroy(explosion, 10.0f);
            }
        }
    }
}
