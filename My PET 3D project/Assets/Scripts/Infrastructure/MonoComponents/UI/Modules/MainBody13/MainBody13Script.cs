using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.MainBody13
{
    public class MainBody13Script : MonoBehaviour
    {
        [SerializeField] private MainBody1Model _mainBody1Model;
        private MainBody1Controler _mainBody1Controler;

        void Start()
        {
            _mainBody1Controler = new MainBody1Controler(_mainBody1Model);
        }


        void Update()
        {

        }
    }
}