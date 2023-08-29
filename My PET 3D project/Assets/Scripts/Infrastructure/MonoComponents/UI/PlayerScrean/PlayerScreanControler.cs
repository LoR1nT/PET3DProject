using Assets.Scripts.UI.Ship;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.PlayerScrean
{
    public class PlayerScreanControler
    {
        private PlayerScreanModel _playerScreanModel;
        private ShipScript _ship;
        private int _health;
        private int _shields;

        public PlayerScreanControler(PlayerScreanModel playerScreanModel)
        {
            _playerScreanModel = playerScreanModel;
        }

        public void Initialize()
        {
            _ship = _playerScreanModel.Ship;
        }

        public void UpdateData()
        {
            _health = _ship.CheckHealth();
            _shields = _ship.CheckShields();
            ChangeUI();
        }

        private void ChangeUI()
        {
            _playerScreanModel.HealhBar.sizeDelta = new Vector2((_health * 5), 0);
            _playerScreanModel.ShieldsBar.sizeDelta = new Vector2((_shields), 0);
        }
    }
}
