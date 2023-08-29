using Assets.Scripts.UI.Ship;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.ShipComponent
{
    public class ShipComponentControler
    {
        private ShipComponentModel _shipComponentModel;
        private int _heath = 0;
        private ShipScript _shipMainScript;
        private int _damagehit = 5;

        public ShipComponentControler(ShipComponentModel shipComponentModel)
        {
            _shipComponentModel = shipComponentModel;            
        }

        public void Initialize()
        {
            _heath = _shipComponentModel.Heath;
            _shipMainScript = _shipComponentModel.ShipMainScript;
        }

        public void DamageInTake()
        {

            if (_heath > 0)
            {
                _heath -= _damagehit;
                _shipMainScript.TakeDamage(_damagehit);
            }
            else if(_heath == 0)
            {
                Debug.Log("Component Destroed  " + _shipComponentModel.ShipComponent.name);
                Object.Destroy(_shipComponentModel.ShipComponent.gameObject);
            }
        }
    }
}
