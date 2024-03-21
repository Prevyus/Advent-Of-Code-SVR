using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AdventOfCodeScript : MonoBehaviour
{
    private void Start()
    {
        RunCode();
    }

    public enum Day
    {
        P1DayOne2019,
        P2DayOne2019,
        P1DayTwo2019,
    };

    public Day currentDay;
    public bool debugAnswer;
    public string answer;

    public void RunCode()
    {
        switch(currentDay)
        {
            case Day.P1DayOne2019:
                RunP1DayOne2019();
            break;

            case Day.P2DayOne2019:
                RunP2DayOne2019();
            break;

            case Day.P1DayTwo2019:
                RunP1DayTwo2019();
            break;
        }
        if (debugAnswer) { Debug.Log(answer); }
    }

    /*
        string textFile = @"C:\Users\SANTIAGO\Documents\GitHub\My-Advent-of-Code\TextFiles\Name.txt";
        string[] lines = File.ReadAllLines(textFile);
    */

    void RunP1DayOne2019() //Finished
    {
        string textFile = @"C:\Users\SANTIAGO\Documents\GitHub\My-Advent-of-Code\TextFiles\P1DayOne2019.txt";
        string[] lines = File.ReadAllLines(textFile);

        float pastLineResult;
        float currLineResult = Mathf.RoundToInt(int.Parse(lines[0]) / 3) - 2;

        for (int i = 1; i < lines.Length; i++)
        {
            pastLineResult = currLineResult;
            currLineResult = pastLineResult + Mathf.RoundToInt(int.Parse(lines[i]) / 3) - 2;
        }

        answer = currLineResult.ToString();
    }


    void RunP2DayOne2019()
    {
        string textFile = @"C:\Users\SANTIAGO\Documents\GitHub\My-Advent-of-Code\TextFiles\P2DayOne2019.txt";
        string[] mass = File.ReadAllLines(textFile);

        float currMass;
        float pastLineFuel;
        float currLineFuel = 0;
        float currSubFuel;

        for (int i = 0; i < mass.Length; i++)
        {
            currMass = int.Parse(mass[i]);
            pastLineFuel = currLineFuel;
            currLineFuel = Mathf.Floor(currMass / 3) - 2;
            fuelSummation = fuelSummation + currLineFuel;
            currSubFuel = Mathf.Floor(currLineFuel / 3) - 2;
            if (currSubFuel > 0) { fuelSummation = fuelSummation + currSubFuel;}
            while (currSubFuel > 0)
            {
                currSubFuel = Mathf.Floor(currSubFuel / 3) - 2;
                if (currSubFuel > 0) { fuelSummation = fuelSummation + currSubFuel; }
            }
            currSubFuel = 0;
            
        }
        answer = fuelSummation.ToString();
        currMass = 0;
        pastLineFuel = 0;
        currLineFuel = 0;
        currSubFuel = 0;
        fuelSummation = 0;
    }
    float fuelSummation = 0;


    void RunP1DayTwo2019()
    {

    }
}
