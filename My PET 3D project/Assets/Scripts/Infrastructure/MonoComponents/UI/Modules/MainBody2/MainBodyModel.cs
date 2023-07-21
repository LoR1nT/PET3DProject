using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.MainBody2
{
    [Serializable]
    public class MainBodyModel
    {
        [SerializeField] private GameObject mainBody;

        public GameObject MainBody { get { return mainBody; } }

    }
}
