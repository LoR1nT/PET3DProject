using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Cockpit3_WithInterior
{
    [Serializable]
    public class Cockpit3_WithInteriorModel
    {
        [SerializeField] private GameObject _cockpit;

        public GameObject Cockpit { get { return _cockpit; } }
    }
}
