using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Crafting
{
    public class ItemRecipe : MonoBehaviour
    {
        [SerializeField]
        private CraftingCapabilities[] _requiredCraftingCapabilities;
        [SerializeField]
        private CraftingCapabilities[] _allowedCraftingCapabilities;

        public GameObject Craft(CraftingIngredient[] craftingIngredients)
        {
            List<MaterialStrengths> materialStrengths = new List<MaterialStrengths>();
            List<MaterialWeaknesses> materialWeaknesses = new List<MaterialWeaknesses>();

            foreach(CraftingIngredient ingredient in craftingIngredients)
            {
                materialStrengths.AddRange(ingredient.MaterialStrengths);
                materialWeaknesses.AddRange(ingredient.MaterialWeaknesses);
            }

            GameObject itemObject = new GameObject();
            Item itemScript = itemObject.AddComponent<Item>();
            itemScript.Setup(materialStrengths.ToArray(), materialWeaknesses.ToArray());

            return itemObject;
        }
    }
}