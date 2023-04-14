using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{

    private int height = 10;
    private int width = 10;
    private float GridSpaceSize = 5f;

    private GameObject[,] gameGrid;

    GameObject gridCellPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //creates the grid in the game
    private void CreateGrid()
    {
        if(gridCellPrefab == null)
        {
            Debug.LogError("ERROR: Grid Cell Prefab on the Game grid is not assigned");
            return;
        }


        //make the grid
        for(int x = 0; x < height; x++)
        {

            for(int y =0; y < width; y++)
            {
                //Create the a new gridSpace object for each cell
                gameGrid[x, y] = Instantiate(gridCellPrefab, new Vector3(x * GridSpaceSize, y * GridSpaceSize), Quaternion.identity);
                gameGrid[x, y].transform.parent = transform;
                gameGrid[x, y].gameObject.name = "Grid Space ( x:" + x.ToString() + "Y :" + y.ToString() + ")";


            }
        }
    }
}
