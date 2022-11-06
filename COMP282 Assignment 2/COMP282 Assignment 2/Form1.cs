using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//COMP282 Assignment 2 
//Alfie Moseley 201353343

namespace COMP282_Assignment_2
{
    public partial class Form1 : Form
    {
        //list of person objects
        private List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrEmpty(AgeBox.Text)) //check both text boxes contain text to input
            {
                string name = NameBox.Text;
                int age = Int32.Parse(AgeBox.Text);
                Person item = new Person(name, age);
                people.Add(item);
                PeopleOutputBox.Items.Add(item.Output());
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(PeopleOutputBox.SelectedIndex >= 0) //check to avoid index out of bounds error
            {
                int choice = PeopleOutputBox.SelectedIndex;
                people.RemoveAt(choice);
                PeopleOutputBox.Items.RemoveAt(choice);

                if(choice > 0 && choice < people.Count) //selected index is not first or last
                {
                    PeopleOutputBox.SelectedIndex = choice;
                }
                else if(choice == 0 && people.Count != 0) //selected index is zero but there is still people in list
                {
                    PeopleOutputBox.SelectedIndex = 0;
                }
                else if(choice == 0 && people.Count == 0) //selected index is zero and list is now empty
                {
                    PeopleOutputBox.SelectedIndex = - 1;
                    NameBox.Text = null;
                    AgeBox.Text = null;
                }
                else //selected index is last person in list
                {
                    PeopleOutputBox.SelectedIndex = choice - 1;
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(PeopleOutputBox.SelectedIndex >= 0) //check to avoid index out of bounds error
            {
                int choice = PeopleOutputBox.SelectedIndex;
                string name = NameBox.Text;
                int age = Int32.Parse(AgeBox.Text);
                Person item = new Person(name, age);
                people[choice] = new Person(name, age);
                PeopleOutputBox.Items[choice] = item.Output();
            }

        }

        private void PeopleOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(PeopleOutputBox.SelectedIndex >= 0) //check to avoid index out of bounds error
            {
                int choice = PeopleOutputBox.SelectedIndex;
                NameBox.Text = people[choice].Name;
                AgeBox.Text = people[choice].Age.ToString();
            }
        }

        private void NameSortButton_Click(object sender, EventArgs e)
        {
            people.Sort(Person.CompareByName);
            
            for(int i = 0; i < people.Count; i++)
            {
                PeopleOutputBox.Items[i] = people[i].Output();
            }
        }

        private void AgeSortButton_Click(object sender, EventArgs e)
        {
            people.Sort(Person.CompareByAge);

            for (int i = 0; i < people.Count; i++)
            {
                PeopleOutputBox.Items[i] = people[i].Output();
            }
        }
    }
}
