using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _mobPrefab1;
    [SerializeField] private GameObject _mobPrefab2;
    [SerializeField] private GameObject _spawner;
    private bool _active = false;
    private int _activeIndex = 3000;
    public int SpawnRate;


    void FixedUpdate()
    {
        if (_active)
        {
            Object.Instantiate(_mobPrefab1,_spawner.transform.position, _spawner.transform.rotation);
            _activeIndex = 3000;
            _active = false;
        }
        else
        {
            if (_activeIndex <= SpawnRate)
            {
                _active = true;
            }
            else
                _activeIndex--;
        }
    }
}
