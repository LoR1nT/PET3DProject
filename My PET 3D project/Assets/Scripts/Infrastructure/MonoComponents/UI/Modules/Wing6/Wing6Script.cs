using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Wing6
{
    public class Wing6Script : MonoBehaviour
    {
        [SerializeField] private Wing6Model _wing6Model;
        private Wing6Controler _wing6Controler;

        void Start()
        {
            _wing6Controler = new Wing6Controler(_wing6Model);
        }

        void Update()
        {

        }
    }
}