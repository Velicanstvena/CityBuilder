using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GridStructureTests
{
    GridStructure structure;
    [OneTimeSetUp]
    public void Init()
    {
        structure = new GridStructure(3, 1000, 1000);
    }

    [Test]
    public void CalculateGridPosition_ShouldReturnVectorOfZeroes_IfPositionWasVectorOfZeroes()
    {
        // Arrange
        //GridStructure structure = new GridStructure(3);
        Vector3 position = new Vector3(0, 0, 0);

        // Act
        Vector3 returnedPosition = structure.CalculateGridPosition(position);

        // Assert
        Assert.AreEqual(Vector3.zero, returnedPosition);
    }

    [Test]
    public void CalculateGridPosition_ShouldReturnVectorOfThrees_IfPositionWasVectorOf2_9And2_9()
    {
        // Arrange
        //GridStructure structure = new GridStructure(3);
        Vector3 position = new Vector3(2.9f, 0, 2.9f);

        // Act
        Vector3 returnedPosition = structure.CalculateGridPosition(position);

        // Assert
        Assert.AreEqual(Vector3.zero, returnedPosition);
    }


    [Test]
    public void CalculateGridPosition_ShouldFail_IfPositionWasVectorOf3_1And0()
    {
        // Arrange
        //GridStructure structure = new GridStructure(3);
        Vector3 position = new Vector3(3.1f, 0, 0f);

        // Act
        Vector3 returnedPosition = structure.CalculateGridPosition(position);

        // Assert
        Assert.AreNotEqual(Vector3.zero, returnedPosition);
    }
}
