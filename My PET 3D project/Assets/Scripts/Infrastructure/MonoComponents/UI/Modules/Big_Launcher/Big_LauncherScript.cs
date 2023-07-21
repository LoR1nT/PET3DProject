using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Big_Launcher
{
    public class Big_LauncherScript : MonoBehaviour
    {
        [SerializeField] private Big_LauncherModel _bigLauncherModel;
        private Big_LauncherControler _bigLauncherControler;


        void Start()
        {
            _bigLauncherControler = new Big_LauncherControler(_bigLauncherModel);
        }


        void Update()
        {

        }
    }
}