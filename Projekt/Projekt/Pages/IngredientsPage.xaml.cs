﻿using Projekt.DAL.Entities;
using Projekt.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekt.Pages
{
    public partial class IngredientsPage : Page
    {
        private static List<string> listOfDietType()
        {
            List<string> list = new List<string>();

            list.Add(Properties.Resources.normal);
            list.Add(Properties.Resources.vegetarian);
            list.Add(Properties.Resources.vegan);

            return list;
        }

        public IngredientsPage()
        {
            InitializeComponent();
            Ingredients_listview.ItemsSource = IngredientsRepos.GetAll();

            DietType_combobox.ItemsSource = listOfDietType();

            if(Login.LOGIN_STATUS)
                Ingredients_stackpanel.IsEnabled = true;
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                string name = Name_textbox.Text;
                double kcal = Convert.ToDouble(Kcal_textbox.Text.Replace('.', ','));
                double protein = Convert.ToDouble(Protein_textbox.Text.Replace('.', ','));
                double fat = Convert.ToDouble(Fat_textbox.Text.Replace('.', ','));
                double carbs = Convert.ToDouble(Carbs_textbox.Text.Replace('.', ','));
                string type = DietType_combobox.SelectedIndex.ToString();

                var newIngredient = new Ingredients(name, kcal, protein, fat, carbs, type);

                IngredientsRepos.Insert(newIngredient);

                Ingredients_listview.ItemsSource = IngredientsRepos.GetAll();
                Ingredients_listview.Items.Refresh();
            }
            catch
            {
                MessageBox.Show(Properties.Resources.errorEmptyDatas, Properties.Resources.warning);
            }
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.,]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
