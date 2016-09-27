﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private List<Animal> animals = new List<Animal>();
        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            int chipNumber = chipNumberCounter(nudChipNumber.Value);
            if (animalTypeComboBox.Text == "Cat")
            {
                SimpleDate simpleDate = new SimpleDate(Convert.ToInt32(nudDayBirthday.Value),
                                                       Convert.ToInt32(nudMonthBirthday.Value),
                                                       Convert.ToInt32(nudYearBirthday.Value));
                try
                {
                    Cat cat = new Cat(chipNumber, simpleDate, tbName.Text, tbBadHabits.Text);
                    animals.Add(cat);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Vul alle waardes in voor cat");
                }

            }
            else if (animalTypeComboBox.Text == "Dog")
            {
                SimpleDate simpleDate = new SimpleDate(Convert.ToInt32(nudDayBirthday.Value),
                                                       Convert.ToInt32(nudMonthBirthday.Value),
                                                       Convert.ToInt32(nudYearBirthday.Value));
                SimpleDate walkDate = new SimpleDate(Convert.ToInt32(nudWalkDay.Value),
                                                       Convert.ToInt32(nudWalkMonth.Value),
                                                       Convert.ToInt32(nudWalkYear.Value));
                Dog dog = new Dog(chipNumber, simpleDate, tbName.Text, walkDate);
                animals.Add(dog);
            }
            else
            {
                MessageBox.Show("Select an Animal!");
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            foreach (Animal animal in animals)
            {
                MessageBox.Show(animal.ToString());
            }

        }

        private void updateForm()
        {
            #region formhandling
            if (animalTypeComboBox.Text  == "Dog")
            {
                lblBadHabits.Visible = false;
                lblWalkDate.Visible = true;
                nudWalkDay.Visible = true;
                nudWalkMonth.Visible = true;
                nudWalkYear.Visible = true;
                tbBadHabits.Visible = false;
            }

            #endregion

            #region formhandling
            if (animalTypeComboBox.Text == "Cat")
            {
                lblBadHabits.Visible = true;
                lblWalkDate.Visible = false;
                nudWalkDay.Visible = false;
                nudWalkMonth.Visible = false;
                nudWalkYear.Visible = false;
                tbBadHabits.Visible = true;
            }

            #endregion
        }
        private int chipNumberCounter(decimal chipNumber)
        {
            if(chipNumber == nudChipNumber.Value)
            {
                chipNumber++;
            }
            nudChipNumber.Value = chipNumber;
            return Convert.ToInt32(chipNumber);
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }
    }
}
