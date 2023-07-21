using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Cockpit3_WithInterior
{
    public class Cockpit3_WithInteriorScript : MonoBehaviour
    {
        [SerializeField] private Cockpit3_WithInteriorModel _cockpitWithInteriorModel;
        private Cockpit3_WithInteriorControler _cockpitWithInteriorControler;

        void Start()
        {
            _cockpitWithInteriorControler = new Cockpit3_WithInteriorControler(_cockpitWithInteriorModel);
        }


        void Update()
        {

        }
    }
}