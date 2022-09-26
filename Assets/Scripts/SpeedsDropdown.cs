using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedsDropdown : MonoBehaviour
{
    private TMP_Dropdown _dropdown;
    //List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
    [SerializeField] private PlayerController _playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        _dropdown = GetComponent<TMP_Dropdown>();
        var speeds = _playerController ? _playerController.Speeds : new int[] { };
        _dropdown.ClearOptions();
        InitOptions(speeds);
    }

    private void InitOptions(int[] speeds)
    {
        foreach (var speed in speeds)
        {
            AddOption(speed + "");
        }
    }

    private void AddOption(string text)
    {
        _dropdown.options.Add(new TMP_Dropdown.OptionData(text));
    }
}
