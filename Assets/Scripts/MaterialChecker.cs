using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaterialChecker : MonoBehaviour
{
    public string nextLevel = "";
    //Names of colors to add to arrays
    public static string bl = "black";
    public static string b = "blue";
    public static string g = "green";
    public static string o = "orange";
    public static string r = "red";
    public static string w = "white";
    public static string y = "yellow";

    //array of materials
    public Material[] Colors = new Material[7];

    //array of cubes in the game
    public GameObject[] CubeArray = new GameObject[64]; 


    //arrays of the correct images as colors and strings
    public string[] ColorSolArr1 = new string[] {  o, o, o, w, w, o, o, o ,
                                                         o, o, o, o, o, o, o, o ,
                                                         o, w, bl, o, o, bl, w, o ,
                                                         o, o, o, o, o, o, o, o ,
                                                         w, o, o, o, o, o, o, w ,
                                                         w, w, w, bl, bl, w, w, w ,
                                                         w, w, w, w, w, w, w, w ,
                                                         w, w, w, w, w, w, w, w };


    public string[] ColorSolArr2 = new string[] { r, r, r, r, r, r, r, r ,
                                                         r, r, r, b, b, b, b, b ,
                                                         r, r, o, b, bl, b, b, bl ,
                                                         r, o, o, b, b, b, b, b ,
                                                         b, o, o, y, y, y, y, r ,
                                                         b, b, o, b, y, y, b, r ,
                                                         r, r, b, r, r, b, r, r ,
                                                         r, r, r, r, r, r, r, r };

    public string[] ColorSolArr3 = new string[] { y, y, g, g, g, g, y, y ,
                                                         y, y, g, g, g, y, g, y ,
                                                         y, y, o, bl, o, bl, y, y ,
                                                         y, y, o, o, r, o, y, y ,
                                                         y, g, b, g, g, b, g, y ,
                                                         y, o, b, b, b, b, o, y ,
                                                         y, y, b, b, b, b, y, y ,
                                                         y, y, bl, y, y, bl, y, y };


    public string[] ColorSolArr4 = new string[] { b, b, b, b, b, b, b, b ,
                                                         b, b, w, w, w, w, b, b ,
                                                         b, b, bl, w, w, bl, b, b ,
                                                         b, b, o, o, o, o, b, b ,
                                                         g, g, o, o, o, o, g, g ,
                                                         g, y, w, r, r, w, y, g ,
                                                         g, g, w, r, r, w, g, g ,
                                                         g, g, y, g, g, y, g, g };


    public string[] ColorSolArr5 = new string[] { b, bl, bl, b, b, b, b, bl ,
                                                         b, b, y, o, b, b, b, o ,
                                                         b, b, b, y, y, y, y, o ,
                                                         o, o, b, y, bl, y, y, bl ,
                                                         o, o, b, r, y, y, y, o ,
                                                         b, y, b, y, o, o, o, b ,
                                                         b, y, y, o, y, o, y, b ,
                                                         g, g, y, o, y, y, o, g };

    private void Start()
    {
        if (nextLevel == "")
        {
            nextLevel = SceneManager.GetActiveScene().name;
        }
    }


    public void Update()
    {

        //VerifyColor(ColorSolArr5, CubeArray, "Level2");
        if (CheckScene())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


    //checks which scene is on and uses the correct array per level
    public bool CheckScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName.Equals("Level1"))
        {

            return VerifyColor(ColorSolArr1, CubeArray, "Level2");
        }

        if (currentSceneName.Equals("Level2"))
        {
            return VerifyColor(ColorSolArr2, CubeArray, "Level3");
        }

        if (currentSceneName.Equals("Level3"))
        {
            return VerifyColor(ColorSolArr3, CubeArray, "Level4");
        }

        if (currentSceneName.Equals("Level4"))
        {
            return VerifyColor(ColorSolArr4, CubeArray, "Level5");
        }

        if (currentSceneName.Equals("Level5"))
        {
            return VerifyColor(ColorSolArr5, CubeArray, "EndScreen");
        }

        return false;
    }




    //method to check if the colors of the cube matches what it should be 
    public bool VerifyColor(string[] ColorSolArr, GameObject[] CubeArr, string nextScene)
    {
        for (int k = 0; k < CubeArr.Length; k++)
        {
            if (!getColor(CubeArr[k]).Equals(ColorSolArr[k]))
            return false;    
            }

        //load the next scene
        //SceneManager.LoadScene(nextScene);
        return true;
    }



    //returns the color of the cube as a string to compare
    private string getColor(GameObject cube)
    {
        Material color = cube.GetComponent<Renderer>().sharedMaterial;
        if (color == (Colors[0]))
        {
            return "black";
        }

        if (color == (Colors[1]))
        {
            return "blue";
        }

        if (color == (Colors[2]))
        {
            return "green";
        }

        if (color == (Colors[3]))
        {
            return "orange";
        }

        if (color == (Colors[4]))
        {
            return "red";
        }

        if (color == (Colors[5]))
        {
            return "white";
        }

        if (color == (Colors[6]))
        {
            return "yellow";
        }
        return null;
    }
}
