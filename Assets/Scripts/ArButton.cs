using System;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;

    [SerializeField] private TextMeshPro _title;

    [SerializeField] private Interactable _interactable;

    private GameObject _prefab;

    public GameObject spawnpoint;
    private SpawnpointScript _spawnpointScript;

    private GameObject newObject;

    private GameObject currentObject;
    private bool checkObject = false;

    private PlayerMoney _pMoney;

    private void Start()
    {
        _pMoney = GameObject.FindWithTag("Player").GetComponent<PlayerMoney>();
        spawnpoint = GameObject.FindWithTag("Spawnpoint");

        _spawnpointScript = spawnpoint.GetComponent<SpawnpointScript>();
    }

    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.Prefab;
        

        _interactable.OnClick.AddListener(ProcessClick);
    } 

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();

        if (_spawnpointScript.checkObject)
        {
            _pMoney._moneyAmount += 50;
            Destroy(_spawnpointScript.currentObject);

        }
        print(checkObject);

        // Получаем поворот spawnpoint
        Quaternion spawnpointRotation = spawnpoint.transform.rotation;

        // Создаем экземпляр объекта с заданным масштабом и поворотом
        GameObject newObject = Instantiate(_prefab, new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z), spawnpointRotation);

        // Устанавливаем масштаб
        newObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    
}