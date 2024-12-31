using System;
using UnityEngine;
namespace lecture18
{
    public class ScoreCalculator : MonoBehaviour
    {
        void Start()
        {


            int playerScore = 100;
            int divisor = 0;


            try
            {
                Debug.Log("Attempting to calculate score multiplier...");


                int totalScore = playerScore / divisor;
            }
            catch (DivideByZeroException)
            {

                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {

                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }

}