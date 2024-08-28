using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assigenment_4
{
    public class RecipeManger
    {
        private Recipe[] recipeList;
        private int numOfElems;


        public RecipeManger(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];

        }
        


        public bool Add(Recipe recipe)
        {
            bool ok = true;
            int index = numOfElems;


            if(recipe != null) { 
            
            if (numOfElems < recipeList.Length)
            {
                recipeList[index] = recipe;
                
                numOfElems++;
            }
            

             else
              ok = false;
            }


            return ok;

        }
        public int FindVacantPostion()
        {
            int index = -1;
            for (int vac = 0; vac < recipeList.Length; vac++)
                if (recipeList[vac] == null)
                {
                    index = vac;
                    break;
                }
            return index;


        }
        

        public void DeleteRecipesAt(int index)
        {

            recipeList[index] = null;
            numOfElems--;
            MoveElementsOneStepToLeft(index);

        }



        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1]; //move 1 step to left
            }
            recipeList[recipeList.Length - 1] = null; //empty last place
        }


        public bool CheckIndex(int index)
        {
            bool check = false;
            if ((index == -1) || (index > recipeList.Length))
                check = true;
            return check;
        }



        public bool Add(string name,FoodCatagory catagory, string[] ingredients)
        {   
            Recipe recipe = new Recipe(ingredients.Length);

            recipe.name = name;
            recipe.Catagory = catagory;
            recipe.ingrediants = ingredients;
            bool ok = Add(recipe);

            





            return ok;

        }
       

        public Recipe GetRecipe(int index)
        {
            Recipe recipe = null;
            if ((index >= 0)&& (index < recipeList.Length))
            {
                recipe = recipeList[index];




            }
            return recipe;  


        }




        public string[] GetRecipeString()
        {
            string[] InfoString = new string[CurrentNumberOfRecipes()];

            for (int i = 0, j = 0; i < recipeList.Length; i++)
                if (recipeList[i] != null)
                {
                    InfoString[j] = recipeList[i].ToString();
                    j++;

                }

            return InfoString;
        }

        public int CurrentNumberOfRecipes()
        {
            int Number = 0;
            for (int i = 0; i < recipeList.Length; i++)
                if (recipeList[i] != null)
                    Number++;
            return Number;
        }
        public bool ChangeElementsAt(int index, Recipe recipe)
        {
            bool change = false;
            if (recipeList[index] != null)
            {
                recipeList[index] = recipe;
                change = true;
            }
            return change;
        }



    }
}
