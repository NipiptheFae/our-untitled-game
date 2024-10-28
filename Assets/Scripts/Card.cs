using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OurUntitledGame
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    
    public class Card : ScriptableObject
    {
        public string cardName;

        public bool isUpgraded;

        public string cardDescription;

        public int cardCost;

        public CardType cardType;
    }

    public enum CardType
    {
        Power,
        Attack,
        Skill
    }
}
