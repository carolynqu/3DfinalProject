using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChecker : MonoBehaviour
{

    Color black = new Color(0, 0, 0);
    Color blue = new Color(5, 172, 255);
    Color green = new Color(67, 255, 38);
    Color orange = new Color(255, 149, 0);
    Color red = new Color(255, 38, 38);
    Color white = new Color(255, 255, 255);
    Color yellow = new Color(255, 210, 31);

    public static string bl = "black";
    public static string b = "blue";
    public static string g = "green";
    public static string o = "orange";
    public static string r = "red";
    public static string w = "white";
    public static string y = "yellow";


    public Material[] Colors = new Material[7];

    public GameObject[] CubeArray = new GameObject[64];


    public string[,] ColorSolArr1 = new string[8, 8] { { o, o, o, w, w, o, o, o },
                                                        { o, o, o, o, o, o, o, o },
                                                        { o, w, bl, o, o, bl, w, o },
                                                        { o, o, o, o, o, o, o, o },
                                                        { w, o, o, o, o, o, o, w },
                                                        { w, w, w, bl, bl, w, w, w },
                                                        { w, w, w, w, w, w, w, w },
                                                        { w, w, w, w, w, w, w, w }};


    public string[,] ColorSolArr2 = new string[8, 8] { {r, r, r, r, r, r, r, r },
                                                        { r, r, r, b, b, b, b, b },
                                                        { r, r, o, b, bl, b, b, bl },
                                                        { r, o, o, b, b, b, b, b },
                                                        { b, o, o, y, y, y, y, r },
                                                        { b, b, o, b, y, y, b, r },
                                                        { r, r, b, r, r, b, r, r },
                                                        { r, r, r, r, r, r, r, r }};

    public string[,] ColorSolArr3 = new string[8, 8] { {y, y, g, g, g, g, y, y },
                                                        { y, y, g, g, g, y, g, y },
                                                        { y, y, o, bl, o, bl, y, y },
                                                        { y, y, o, o, r, o, y, y },
                                                        { y, g, b, g, g, b, g, y },
                                                        { y, o, b, b, b, b, o, y },
                                                        { y, y, b, b, b, b, y, y },
                                                        { y, y, bl, y, y, bl, y, y }};


    public string[,] ColorSolArr4 = new string[8, 8] { {b, b, b, b, b, b, b, b },
                                                        { b, b, w, w, w, w, b, b },
                                                        { b, b, bl, w, w, bl, b, b },
                                                        { b, b, o, o, o, o, b, b },
                                                        { g, g, o, o, o, o, g, g },
                                                        { g, y, w, r, r, w, y, g },
                                                        { g, g, w, r, r, w, g, g },
                                                        { g, g, y, g, g, y, g, g }};


    public string[,] ColorSolArr5 = new string[8, 8] { {b, bl, bl, b, b, b, b, bl },
                                                        { b, b, y, o, b, b, b, o },
                                                        { b, b, b, y, y, y, y, o },
                                                        { o, o, b, y, bl, y, y, bl },
                                                        { o, o, b, r, y, y, y, o },
                                                        { b, y, b, y, o, o, o, b },
                                                        { b, y, y, o, y, o, y, b },
                                                        { g, g, y, o, y, y, o, g }};


    public string[,] ColorTestArr = new string[4, 4] { { w, w, w, w }, { w, w, w, w }, { w, w, w, w }, { w, w, w, bl } };



    public string[,] CurrColor = new string[8, 8];



    public void Update()
    {
        VerifyColor(ColorTestArr, CubeArray);
    }



    public bool VerifyCubes(string[,] ColorSolArr, string[,] CurrColor)
    {

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {

                if (!ColorSolArr[i, j].Equals(CurrColor[i, j]))
                {
                    return false;
                }

            }

        }
        return true;
    }



    public bool VerifyColor(string[,] ColorSolArr, GameObject[] CubeArr)
    {
        for (int i = 0; i < ColorSolArr.Length; i++)
        {
            for (int j = 0; j < ColorSolArr.Length; j++)
            {
                for (int k = 0; k < CubeArr.Length; k++)
                {
                    if (!getColor(CubeArr[k]).Equals(ColorSolArr[i, j]))
                        return false;
                }
            }
        }
        return true;
    }


    private string getColor(GameObject cube)
    {
        Renderer color = cube.GetComponent<Renderer>();
        if (color.Equals(Colors[0]))
        {
            return "black";
        }

        if (color.Equals(Colors[1]))
        {
            return "blue";
        }

        if (color.Equals(Colors[2]))
        {
            return "green";
        }

        if (color.Equals(Colors[3]))
        {
            return "orange";
        }

        if (color.Equals(Colors[4]))
        {
            return "red";
        }

        if (color.Equals(Colors[5]))
        {
            return "white";
        }

        if (color.Equals(Colors[6]))
        {
            return "yellow";
        }
        return null;
    }
}
