namespace Assigenment_4
{
    public partial class MainForm : Form
    {
        const int Maxnumberofingredients = 50;
        const int Maxnumberofrecipes = 200;
        public Recipe currRecipe;
        public RecipeManger recipeMngr = new RecipeManger(Maxnumberofrecipes);






        public MainForm()
        {


            InitializeComponent();



            comboBox1.Items.AddRange(Enum.GetNames(typeof(FoodCatagory)));
            comboBox1.SelectedIndex = 0;



            





        }





        private void BtnAddIng_Click(object sender, EventArgs e)
        {

            currRecipe = new Recipe(Maxnumberofingredients);
            FormIngrediants form = new FormIngrediants(currRecipe);

            string newTitle = txtRecipeName.Text;
            if (string.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("What is the recipe name");

            }


            else
            {
                form.Text = newTitle;





                DialogResult dlg = form.ShowDialog();


                if (dlg == DialogResult.OK)
                {

                    if (currRecipe.CurrentNumberOfIngradients() <= 0)
                    {
                        MessageBox.Show("No ingradients added");
                    }



                }

            }











        }


        private void UpdateGUI()
        {

            string[] infostring = recipeMngr.GetRecipeString();
            LstRecipes.Items.Clear();
            if ((infostring != null) && (infostring.Length > 0))
            {
                LstRecipes.Items.AddRange(infostring);
                txtRecipeName.Clear();
                TxtInstrouctions.Clear();
            }

        }








        private void BtnAddRecipe_Click(object sender, EventArgs e)
        {
            string newTitle = txtRecipeName.Text;
            if (string.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("What is the recipe name");
            }


            else if (currRecipe == null)
            {
                MessageBox.Show("No ingradients Added!!!");
            }
            else
            {
                currRecipe.name = newTitle;
                currRecipe.Catagory = (FoodCatagory)comboBox1.SelectedIndex;
                 
                currRecipe.discription = TxtInstrouctions.Text;

                recipeMngr.Add(currRecipe);

                UpdateGUI();
            }



        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = LstRecipes.SelectedIndex;
            if (index != -1)
            {

                Recipe recipe = recipeMngr.GetRecipe(index);
                if (recipe != null)
                {



                    string Ingradients = string.Join("  ", recipe.GetIngradientsString());
                    MessageBox.Show("Ingradients: " + " \n" + Ingradients + "\n " + "\nInstrouctions: "+ "\n " + TxtInstrouctions.Text, "Cooking Instructions");

                }
            }
            else
                MessageBox.Show("Choose an item!!!");





            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LstRecipes.SelectedIndex;





            if (index != -1)
            {

                Recipe recipe = recipeMngr.GetRecipe(index);
                if (recipe != null)
                {
                    
                    txtRecipeName.Text = recipe.name;
                    comboBox1.SelectedItem = recipe.Catagory.ToString();
                    TxtInstrouctions.Text = recipe.discription;






                }
            }
            

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            int index = LstRecipes.SelectedIndex;


            if (recipeMngr.CheckIndex(index))
                MessageBox.Show("No Recipe selected", "Error");
            else
            {
                recipeMngr.DeleteRecipesAt(index);
                UpdateGUI();
            }
        }

        private void btnEditRec_Click(object sender, EventArgs e)
        {
            TxtInstrouctions.ReadOnly = false;
            Recipe recipe = recipeMngr.GetRecipe(LstRecipes.SelectedIndex);
            FormIngrediants form = new FormIngrediants(recipe);
            DialogResult dlg = form.ShowDialog();
            if (dlg == DialogResult.OK)
            {

                if (currRecipe.CurrentNumberOfIngradients() <= 0)
                {
                    MessageBox.Show("No ingradients added");
                }



            }










        }

        private void ClearSelection()
        {
            TxtInstrouctions.ReadOnly = true;
            txtRecipeName.Text = string.Empty;
            TxtInstrouctions.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            LstRecipes.SelectedIndex = -1;


        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Recipe recipe = recipeMngr.GetRecipe(LstRecipes.SelectedIndex);
            FoodCatagory catagory = (FoodCatagory)Enum.Parse(typeof(FoodCatagory), comboBox1.SelectedItem.ToString());
            recipe.Catagory = catagory;
            recipe.name = txtRecipeName.Text;
            recipe.discription = TxtInstrouctions.Text;
            UpdateGUI();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
