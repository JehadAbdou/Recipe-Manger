using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace Assigenment_4
{
    public partial class FormIngrediants : Form
    {


        

        private Recipe recipe;


      

        public FormIngrediants(Recipe recipe)
        {

            this.recipe = recipe;

            InitializeComponent();
            
            InitializGUI();

            UpdateGUI();


        }

        public void InitializGUI()
        {
            


        }

        public void UpdateGUI()
        {
            string[] infostring = recipe.GetIngradientsString();
            LstIngradients.Items.Clear();
            if ((infostring != null) && (infostring.Length > 0))
            {
                LstIngradients.Items.AddRange(infostring);
                TxtIngradients.Clear();
            }

        }

        




        public Recipe Recipe
        {
            get { return recipe; }

            set { recipe = value; }
        }





        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
         

            // Check if the Ingredients array is not null
            if (recipe.ingrediants != null)
            {
                
                recipe.AddIngrediants(TxtIngradients.Text);
                UpdateGUI();
               
             
                
            }
            
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = LstIngradients.SelectedIndex;

            if (recipe.CheckIndex(index))
                MessageBox.Show("No Ingradients selected", "Error");
            else
            {
                recipe.ChangeIngradientsAt(index ,TxtIngradients.Text);
                UpdateGUI();
            }

        }

        private void BtnReove_Click(object sender, EventArgs e)
        {

            int index = LstIngradients.SelectedIndex;
            

            if (recipe.CheckIndex(index))
                MessageBox.Show("No Ingradients selected", "Error");
            else
            {
                recipe.DeleteIngradientsAt(index);
                UpdateGUI();
            }
        }

      
        
    }
}
