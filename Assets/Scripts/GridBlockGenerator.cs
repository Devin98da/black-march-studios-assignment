using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBlockGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _gridBlockPrefab;
    [SerializeField] private int _gridSize;
    [SerializeField] private float _spacing;


    private void Start()
    {
        GenerateGrid();
    }

    // GENERATE GUID    
    private void GenerateGrid()
    {
        for (int row = 0; row < _gridSize; row++)
        {
            for (int column = 0; column < _gridSize; column++)
            {
                Vector3 spawnPosition = new Vector3(row * _spacing, 0, column * _spacing);
                GameObject obj = Instantiate(_gridBlockPrefab, spawnPosition, Quaternion.identity);
                obj.transform.SetParent(transform);
                GridBlock gridBlock = obj.GetComponent<GridBlock>();
                gridBlock.row = row;
                gridBlock.column = column;
                gridBlock.id = System.Guid.NewGuid().ToString();
                gridBlock.position = obj.transform.position;

            }
        }
    }


}
