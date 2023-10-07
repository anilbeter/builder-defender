using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private Camera mainCam;
    [SerializeField] private BuildingTypeSO buildingType;

    private void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        // 0 -> left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // sol tıkladığımda mouse ın olduğu yerde spawnlancak
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
}
