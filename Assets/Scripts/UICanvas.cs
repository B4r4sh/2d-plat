using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvas : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _deathPanel;

    private void Start()
    {
        _winPanel.SetActive(false);
        _deathPanel.SetActive(false);
    }
}
