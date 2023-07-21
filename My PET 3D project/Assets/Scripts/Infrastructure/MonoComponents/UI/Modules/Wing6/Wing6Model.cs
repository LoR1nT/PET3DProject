using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Wing6
{
    [Serializable]
    public class Wing6Model
    {
        [SerializeField] private GameObject _wing;

        public GameObject Wing { get { return _wing; } }
    }
}
