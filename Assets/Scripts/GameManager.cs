using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LayerMask _rayLayerMask;
    private GridBlock _gridBlock;
    private bool _isHoverOnGridBrick;

    private void Update()
    {
        RayFromMouse();

        if(_isHoverOnGridBrick)
        {

        }
        else
        {

        }
    }

    // RAY FROM MOUSE
    private void RayFromMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
        RaycastHit hit;

        if(Physics.Raycast( ray, out hit, 100, _rayLayerMask ))
        {
            if(hit.collider != null )
            {
                _gridBlock = hit.collider.GetComponent<GridBlock>();
                _gridBlock?.ShowGridDetails();
            }
        }
        else
        {
            Debug.Log("no collider");

            UIManager.Instance.ShowHideGridTileInfoPanel(false);
        }
    }
}
