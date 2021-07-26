using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    private GameObject structureModel = null;
    private bool isTaken = false;

    public bool IsTaken { get => isTaken; }

    public void SetConstruction(GameObject structureModel)
    {
        if (structureModel == null)
            return;

        this.structureModel = structureModel;
        this.isTaken = true;
    }
}
