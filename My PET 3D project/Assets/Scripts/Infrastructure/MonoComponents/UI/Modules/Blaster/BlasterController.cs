using UnityEngine;

namespace Assets.Scripts.UI.Modules.Blaster
{
    public class BlasterController
    {
        private BlasterModel _blasterModel;

        public BlasterController(BlasterModel blasterModel)
        {
            _blasterModel = blasterModel;
        }

        public void Fire()
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = GameObject.Instantiate(_blasterModel.BulletPrefab, _blasterModel.BlasterFirePoint.transform.position, _blasterModel.BlasterFirePoint.transform.rotation);

                bullet.GetComponent<Rigidbody>().velocity = _blasterModel.BlasterFirePoint.transform.forward * _blasterModel.BulletSpeed;
            }
        }
    }
}
