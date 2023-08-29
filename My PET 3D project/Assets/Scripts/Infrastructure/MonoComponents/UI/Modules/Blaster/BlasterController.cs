using UnityEngine;

namespace Assets.Scripts.UI.Modules.Blaster
{
    public class BlasterController
    {
        private BlasterModel _blasterModel;
        private bool _active = false;
        private int _activeIndex = 0;
        private int _fireRate;

        public BlasterController(BlasterModel blasterModel)
        {
            _blasterModel = blasterModel;
        }

        public void Intialize()
        {
            _fireRate = (11 - _blasterModel.FireRate);
        }

        public void Fire()
        {
            if(_blasterModel.IsPlayer)
            {
                if (_active)
                {
                    if (Input.GetMouseButton(0))
                    {
                        BlasterBulletScript bullet = Object.Instantiate(_blasterModel.BulletPrefab, _blasterModel.BlasterFirePoint.transform.position, _blasterModel.BlasterFirePoint.transform.rotation);
                        _blasterModel.ParticleSystem.Play();
                        bullet.Rigidbody.velocity = _blasterModel.BlasterFirePoint.transform.forward * _blasterModel.BulletSpeed;
                        bullet.gameObject.layer = _blasterModel.BlasterFirePoint.layer;
                        _activeIndex = 0;
                        _active = false;
                    }
                }
                else
                {
                    if (_activeIndex == _fireRate)
                    {
                        _active = true;
                    }
                    else
                        _activeIndex++;
                }
            }

        }
    }
}
