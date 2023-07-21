using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.MainBody13
{
    [Serializable]
    public class MainBody1Model
    {
        [SerializeField] private GameObject _mainBody1;

        public GameObject MainBody1 { get { return _mainBody1; } }
    }
}
