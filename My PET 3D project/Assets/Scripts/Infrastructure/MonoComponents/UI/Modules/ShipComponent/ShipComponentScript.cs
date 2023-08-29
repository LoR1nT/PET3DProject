using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.ShipComponent
{
    public class ShipComponentScript : MonoBehaviour
    {
        [SerializeField] private ShipComponentModel _shipComponentModel;
        private ShipComponentControler _shipComponentControler;

        private void Awake()
        {
            _shipComponentControler = new ShipComponentControler(_shipComponentModel);            
        }

        private void Start()
        {
            _shipComponentControler.Initialize();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.layer != _shipComponentModel.ShipComponent.layer)
            {
                var bullet = other.gameObject.GetComponent<BlasterBulletScript>();
                if (bullet != null)
                {
                    bullet.BulletDestroy();
                }
                _shipComponentControler.DamageInTake();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.layer != _shipComponentModel.ShipComponent.layer)
            {
                var bullet = other.gameObject.GetComponent<BlasterBulletScript>();
                if (bullet != null)
                {
                    bullet.BulletDestroy();
                }
                _shipComponentControler.DamageInTake();
            }
        }

    }
}