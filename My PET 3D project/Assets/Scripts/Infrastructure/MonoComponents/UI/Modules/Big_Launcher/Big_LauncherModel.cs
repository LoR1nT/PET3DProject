using System;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.Modules.Big_Launcher
{
    [Serializable]
    public class Big_LauncherModel
    {
        [SerializeField] private GameObject _firePoint;
        [SerializeField] private GameObject _launcher;
        [SerializeField] private int _speedOfRocket;

        public GameObject FirePoint { get { return _firePoint; } }
        public GameObject Launcher { get { return _launcher;} }
        public int SpeedOfRocket { get {  return _speedOfRocket; } }
    }
}
