using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Player.Clothes 
{
    public class PlayerClothes : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer hood;
        [SerializeField] private SpriteRenderer[] shoulder;
        [SerializeField] private SpriteRenderer[] elbow;
        [SerializeField] private SpriteRenderer[] wrist;
        [SerializeField] private SpriteRenderer torso;
        [SerializeField] private SpriteRenderer[] leg;
        [SerializeField] private SpriteRenderer[] boots;

        [SerializeField] private PlayerClothesContainer playerClothesContainer;

        private void Start()
        {
            playerClothesContainer.onClotheBought += UpdateClothes;
            playerClothesContainer.UpdateCurrentClothe();
        }

        public void UpdateClothes() 
        {
            hood.sprite = playerClothesContainer.hood;
            shoulder[0].sprite = playerClothesContainer.shoulder[0];
            shoulder[1].sprite = playerClothesContainer.shoulder[1];
            elbow[0].sprite = playerClothesContainer.elbow[0];
            elbow[1].sprite = playerClothesContainer.elbow[1];
            wrist[0].sprite = playerClothesContainer.wrist[0];
            wrist[1].sprite = playerClothesContainer.wrist[1];
            torso.sprite = playerClothesContainer.torso;
            leg[0].sprite = playerClothesContainer.leg[0];
            leg[1].sprite = playerClothesContainer.leg[1];
            boots[0].sprite = playerClothesContainer.boots[0];
            boots[1].sprite = playerClothesContainer.boots[1];
        }
    }
}
