using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Crafting
{
    public enum CraftingCapabilities
    {
        IsElastic,
        IsSolid,
        BindsTogether,
        CanBeUsedAsHandle,
        SealsUp,
        IsSturdy,
        IsSharp,
        IsPointy,
        IsRawMaterial,
    }

    public enum MaterialStrengths
    {
        MakesFlameproof,
        MakesWaterproof,
        MakesAcidproof,
        EmitsLight,
        Insulates,
    }

    public enum MaterialWeaknesses
    {
        DissolvesInWater,
        AttractsAttention,
        IsBrittle,
    }

    public class CraftingIngredient : MonoBehaviour
    {
        [SerializeField]
        private CraftingCapabilities[] _craftingCapabilities;
        [SerializeField]
        private MaterialStrengths[] _materialStrengths;
        [SerializeField]
        private MaterialWeaknesses[] _materialWeaknesses;

        public CraftingCapabilities[] CraftingCapabilities { get => _craftingCapabilities; private set => _craftingCapabilities = value; }
        public MaterialStrengths[] MaterialStrengths { get => _materialStrengths; private set => _materialStrengths = value; }
        public MaterialWeaknesses[] MaterialWeaknesses { get => _materialWeaknesses; private set => _materialWeaknesses = value; }
    }

    // Add Custom Inspector that lets you configure some options further
    // For example: If MaterialWeaknes 'AttractsAttention' is chosen,
    // Show an array in which enemies can be specified
}