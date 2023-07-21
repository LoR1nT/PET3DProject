using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.MainBody2
{
    public class MainBody2Script : MonoBehaviour
    {
        [SerializeField] private MainBodyModel _mainBodyModel;
        private MainBodyControler _mainBodyControler;


        void Start()
        {
            _mainBodyControler = new MainBodyControler(_mainBodyModel);
        }


        void Update()
        {

        }
    }
}