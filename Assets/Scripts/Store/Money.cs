using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store 
{
    [CreateAssetMenu(fileName = "Money", menuName = "Store/CurrentMoney")]
    public class Money : ScriptableObject
    {
        public int currentMoney;
    }
}
