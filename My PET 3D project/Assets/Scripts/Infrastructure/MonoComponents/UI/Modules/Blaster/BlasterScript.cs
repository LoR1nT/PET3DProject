using UnityEngine;


namespace Assets.Scripts.UI.Modules.Blaster
{
    public class BlasterScript : MonoBehaviour
    {
        [SerializeField] private BlasterModel _blasterModel;
        private BlasterController _blasterController;

        private void Start()
        {
            _blasterController = new BlasterController(_blasterModel);
            _blasterController.Intialize();
        }

        void FixedUpdate()
        {
            _blasterController.Fire();
        }
    }
}