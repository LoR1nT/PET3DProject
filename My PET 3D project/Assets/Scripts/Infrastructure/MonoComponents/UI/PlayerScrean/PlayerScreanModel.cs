using Assets.Scripts.UI.Ship;
using System;
using UnityEngine;

namespace Assets.Scripts.Infrastructure.MonoComponents.UI.PlayerScrean
{
    [Serializable]
    public class PlayerScreanModel
    {
        [SerializeField] private RectTransform _healthBar;
        [SerializeField] private RectTransform _shieldsBar;
        [SerializeField] private ShipScript _ship;

        public RectTransform HealhBar { get { return _healthBar; } set { } }
        public RectTransform ShieldsBar { get { return _shieldsBar; } set { } }
        public ShipScript Ship { get { return _ship; } }

    }
}
