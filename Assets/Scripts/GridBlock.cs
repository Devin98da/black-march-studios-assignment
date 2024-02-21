using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBlock : MonoBehaviour
{
    public string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public int row;
    public int column;
    public Vector3 position;

    //SHOW GRID DETAILS
    public void ShowGridDetails()
    {
        
        UIManager.Instance.UpdateTileInfo(id, row, column, position);
    }
}
