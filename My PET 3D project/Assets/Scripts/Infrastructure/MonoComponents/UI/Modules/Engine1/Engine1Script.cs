using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Engine1
{
    public class Engine1Script : MonoBehaviour
    {
        [SerializeField] private EngineModel _engineModel;
        private EngineControler _engineControler;

        void Start()
        {
            _engineControler = new EngineControler(_engineModel);
        }


        void Update()
        {

        }
    }
}