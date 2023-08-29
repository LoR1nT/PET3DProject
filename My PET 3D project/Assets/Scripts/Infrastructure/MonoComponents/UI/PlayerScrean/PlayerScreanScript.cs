using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.PlayerScrean
{
    public class PlayerScreanScript : MonoBehaviour
    {
        [SerializeField] private PlayerScreanModel _playerScreanModel;
        private PlayerScreanControler _playerScreanControler;

        private void Awake()
        {
            _playerScreanControler = new PlayerScreanControler(_playerScreanModel);            
        }

        void Start()
        {
            _playerScreanControler.Initialize();
        }

        void FixedUpdate()
        {
            _playerScreanControler.UpdateData();
        }
    }
}