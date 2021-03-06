﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Meals
    {
        private double Kcal, Proteins, Fat, Carbs, TotalGrams;

        private static double[][] mealsMatrix = new double[][]
        {
            new double[]{ 0.45, 0.55 },
            new double[]{ 0.3, 0.45, 0.25 },
            new double[]{ 0.28, 0.15, 0.35, 0.22 },
            new double[]{ 0.24, 0.12, 0.3, 0.16, 0.2 }
        };

        public List<Meal> ListOfMeals { get; private set; } = new List<Meal>();

        public Meals(int mealCount, double calories, int dietType, int goal, double weight)
        {
            var totalProteins = GetTotalProteins(goal, weight);
            var totalFat      = GetTotalFat(calories);
            var totalCarbs    = GetTotalCarbs(calories, totalProteins, totalFat);

            var proteins = GetMacroArray(mealCount, totalProteins);
            var fat      = GetMacroArray(mealCount, totalFat);
            var carbs    = GetMacroArray(mealCount, totalCarbs);

            double Kcal = 0, Fat = 0, Proteins = 0, Carbs = 0, TotalGrams = 0;

            for (int i = 0; i < mealCount; i++)
            {
                ListOfMeals.Add(
                    new Meal(
                        dietType,
                        proteins[i],
                        fat[i],
                        carbs[i]
                        )
                    );
                Kcal       += ListOfMeals[i].Kcal;
                Proteins   += ListOfMeals[i].Proteins;
                Fat        += ListOfMeals[i].Fat;
                Carbs      += ListOfMeals[i].Carbs;
                TotalGrams += ListOfMeals[i].TotalGrams;
            }

            this.Kcal = Kcal; this.Fat = Fat; 
            this.Proteins = Proteins; 
            this.Carbs = Carbs; this.TotalGrams = TotalGrams;
        }

        private double []GetMacroArray(int mealCount, double macro)
        {
            var arr = new double[mealCount];

            var n = mealCount - 2;

            for (int i = 0; i < mealCount; i++)
                arr[i] = (mealsMatrix[n][i] * macro);

            return arr;
        }

        private double GetTotalProteins(int goal, double weight) //[grams]
        {
            if (goal == 0)
                return (2 * weight);

            if (goal == 1)
                return (1.7 * weight);

            return(1.8 * weight); 
        }

        private double GetTotalFat(double calories) // [grams]
            => 0.275 * calories / 9; 

        private double GetTotalCarbs(double calories, double proteins, double fat) // [grams]
            => (calories - (proteins * 4 + fat * 9)) / 4;

        public override string ToString()
        {
            return $"\nTOTAL:" +
                   $"\nProteins  {Proteins.ToString("0.##")} g = {(Proteins * 4).ToString("0.##")} Kcal" +
                   $"\nFat       {Fat.ToString("0.##")} g = {(Fat * 9).ToString("0.##")} Kcal" +
                   $"\nCarbs     {Carbs.ToString("0.##")} g = {(Carbs * 4).ToString("0.##")} Kcal" +
                   $"\nTotalgram {TotalGrams.ToString("0.##")} g = {Kcal.ToString("0.##")} Kcal";
        }
    }
}