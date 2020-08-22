using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    /*
* Name: amish tangri
* Student ID: 301108446
* Date: August 21, 2020
*/

    public partial class GenerateNameForm : Form
    {
        public void GenerateNames()
        {
            //generating random names in the textboxes from the list
            var random = new Random();
            int indexfirst = random.Next(0, FirstNameListBox.Items.Count);
            firstNameTextBox.Text = FirstNameListBox.Items[indexfirst].ToString();

            int indexlast = random.Next(0, lastNameListBox.Items.Count);
            LastNameTextBox.Text = lastNameListBox.Items[indexlast].ToString();
        }
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        // when generate name form loads
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //generate name method is called
            GenerateNames();
        }

        // when generate name button is clicked
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //generate name method is called
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Program.character.FirstName = firstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

            // instantiated abilitygeneratorform object
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            //this will abilitygenerator form
            abilityGeneratorForm.Show();

            //this will generate name form
            Program.generatenameform.Hide();
        }
    }
}
