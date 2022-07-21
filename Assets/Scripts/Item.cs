using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crafting
{
    public class Item : MonoBehaviour
    {
        private MaterialStrengths[] _materialStrengths = null;
        private MaterialWeaknesses[] _materialWeaknesses = null;

        public bool IsSetup
        {
            get
            {
                return _materialStrengths != null && _materialWeaknesses != null;
            }
        }

        public void Setup(MaterialStrengths[] strengths, MaterialWeaknesses[] weaknesses)
        {
            _materialStrengths = strengths;
            _materialWeaknesses = weaknesses;
        }
    }

}