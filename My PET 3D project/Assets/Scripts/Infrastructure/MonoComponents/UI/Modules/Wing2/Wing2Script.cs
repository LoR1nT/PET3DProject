using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Wing2
{
    public class Wing2Script : MonoBehaviour
    {
        [SerializeField] private Wing2Model _wing2Model;
        private Wing2Controler _wing2Controler;

        void Start()
        {
            _wing2Controler = new Wing2Controler(_wing2Model);
        }

        void Update()
        {

        }
    }
}