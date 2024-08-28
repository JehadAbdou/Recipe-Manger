using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assigenment_4
{
    public class Recipe
    {
        private FoodCatagory catagory;
        private string Discription;
        private string[] Ingredients;
        private string Name;
        private int maxNumOfIngradient;
        private int NumOfElems;

        public FoodCatagory Catagory
        {
            get { return catagory; }
            set { catagory = value; }
        }

        public string discription
        {
            get { return Discription; }
            set { Discription = value; }
        }

        public string[] ingrediants
        {
            get { return Ingredients; }
            set { Ingredients = value; }
        }

        public int MaxNumOfIngradients
        {
            get { return maxNumOfIngradient; }
        }

        public string name
        {
            get { return Name; }
            set {
                if(!string.IsNullOrEmpty(value))
                    Name = value;
                }
        }

        public bool AddIngrediants(string ingredient)
        {
            bool ok = false;
            int index = NumOfElems;

            if((ingredient != null)&&(ingredient!=string.Empty))
            { 

               if (NumOfElems < Ingredients.Length)
               {
                Ingredients[index] = ingredient;
                
                NumOfElems++;
               }


            }
            else
                ok = false;


            return ok;
            
        }

        public bool ChangeIngradientsAt(int index, string value)
        {
            bool change = false;
            if (!string.IsNullOrEmpty(ingrediants[index])&&(value != string.Empty))
            {
                ingrediants[index] = value;
                change = true;
            }
            return change;
        }

        public bool CheckIndex(int index)
        {
            bool check = false;
            if ((index == -1)||(index > Ingredients.Length))
                check = true;
            return check;
        }

        public int CurrentNumberOfIngradients()
        {
            int Number = 0;
            for (int i = 0; i < Ingredients.Length; i++)
                if (Ingredients[i] != null)
                    Number++;
            return Number;
        }

        public void DefaultValues()
        {
            Name = string.Empty;
            discription = string.Empty;
            ingrediants = null;
            catagory = FoodCatagory.Meats;
        }

        public void DeleteIngradientsAt(int index)
        {
            
            Ingredients[index] = null;
            
            NumOfElems--;
            MoveElementsOneStepToLeft(index);
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < Ingredients.Length - 2; i++)
            {
                Ingredients[i] = Ingredients[i + 1]; //move 1 step to left
            }
            Ingredients[Ingredients.Length - 1] = null; //empty last place
        }


        public int FindVacantPostion()
        {
            int index = -1;
            for (int vac = 0; vac < Ingredients.Length; vac++)
                if (Ingredients[vac] == null) { 
                    index = vac;
                    break;
                }
            return index;
                    
           
        }

        public string[] GetIngradientsString()
        {
            string[] InfoString = new string[CurrentNumberOfIngradients()];

            for (int i = 0,j = 0; i < Ingredients.Length;i++)
                if (Ingredients[i] != null)
                {
                    InfoString[j] = Ingredients[i].ToString();
                    j++;

                }
           
            return InfoString;
        }

        public Recipe(int maxNumOFIngradient)
        {
            
            
            Ingredients = new string[maxNumOFIngradient];
            

        }

        public override string ToString()
        {
            
            string obj = string.Format("   {0,-15} {1,-15} {2,10}", Name, catagory, CurrentNumberOfIngradients());

            

            return obj ;
        }
    }
}
