using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static Difficulty instance;

    public string difficulty;
    public int num;

    public void Easy()
    {
        System.Console.WriteLine("hello");
        difficulty = "easy";
        num = 3;
    }
    public void Medium()
    {
        difficulty = "medium";
        num = 2;
    }
    public void Hard()
    {
        difficulty = "hard";
        num = 1;
    }
}
