using UnityEngine;

namespace Assets.Scripts.UI.Ship
{
    public class ShipScript : MonoBehaviour
    {
        [SerializeField] private ShipModel _shipModel;
        private ShipControler _shipControler;


        void Start()
        {
            _shipControler = new ShipControler(_shipModel);
            _shipControler.Initialize();
        }

        private void Update()
        {
            _shipControler.Movement();
            _shipControler.IsDestroedShip();
        }

        public void TakeDamage(int damage)
        {
            _shipControler.DamageRegistration(damage);
        }

        public int CheckHealth()
        {
            return _shipControler.Health;
        }

        public int CheckShields()
        {
            return _shipControler.Shield;
        }
    }
}