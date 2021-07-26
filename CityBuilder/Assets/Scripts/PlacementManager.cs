using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    [SerializeField] GameObject buildingPrefab;
    [SerializeField] Transform ground;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void CreateBuilding(Vector3 gridPosition, GridStructure grid)
    {
        GameObject newStructure = Instantiate(buildingPrefab, ground.position + gridPosition, Quaternion.identity);
        grid.PlaceStructureOnTheGrid(newStructure, gridPosition);
    }
}
