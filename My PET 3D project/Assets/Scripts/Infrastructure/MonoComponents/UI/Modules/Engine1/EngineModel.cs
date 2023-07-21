using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Engine1
{
    [Serializable]
    public class EngineModel
    {
        [SerializeField] private GameObject _engine;

        public GameObject Engine { get { return _engine; } }
    }
}
