using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Wing2
{
    [Serializable]
    public class Wing2Model
    {
        [SerializeField] private GameObject _wing2;

        public GameObject Wing2 { get { return _wing2; } }
    }
}
