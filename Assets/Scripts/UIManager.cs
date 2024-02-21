using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
   public static UIManager Instance
    {
        get
        {
            return _instance;
        }
    }

    [Header("Grid Tile Info")]
    [SerializeField] private GameObject _gridTileInfoPanel;
    [SerializeField] private TextMeshProUGUI _idText, _rowText, _columnText, _positionText;

    private static UIManager _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }

    // UPDATE TILE INFO 
    public void UpdateTileInfo(string id, int row, int column, Vector3 position)
    {
        RectTransform rectTransform = _gridTileInfoPanel.transform.GetComponent<RectTransform>();
        rectTransform.position = Input.mousePosition - rectTransform.position/2;

        _gridTileInfoPanel.SetActive(true);
        _idText.text = id;
        _rowText.text = row.ToString();
        _columnText.text = column.ToString();
        _positionText.text = position.ToString();
    }

    // HIDE TILE INFO PANEL
    public void ShowHideGridTileInfoPanel(bool isHide)
    {
        _gridTileInfoPanel.SetActive(isHide);

    }
}
