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
        }

        void Update()
        {
            _blasterController.Fire();
        }
    }
}