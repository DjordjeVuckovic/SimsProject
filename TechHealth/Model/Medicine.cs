// File:    Medicine.cs
// Author:  djord
// Created: Monday, March 28, 2022 10:08:11 AM
// Purpose: Definition of Class Medicine

using System;
using System.Collections.Generic;

namespace TechHealth.Model
{
   public class Medicine
   {
      public string medicineId;
      public List<String> composition;
      public int quantity;
      public string sideEffects;
      public string mainSupsance;
      public bool harmful;
      public double price;
      public double medineName;
      
      public System.Collections.Generic.List<Allergen> allergen;
      
      /// <summary>
      /// Property for collection of Allergen
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Allergen> Allergen
      {
         get
         {
            if (allergen == null)
               allergen = new System.Collections.Generic.List<Allergen>();
            return allergen;
         }
         set
         {
            RemoveAllAllergen();
            if (value != null)
            {
               foreach (Allergen oAllergen in value)
                  AddAllergen(oAllergen);
            }
         }
      }
      
      /// <summary>
      /// Add a new Allergen in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAllergen(Allergen newAllergen)
      {
         if (newAllergen == null)
            return;
         if (this.allergen == null)
            this.allergen = new System.Collections.Generic.List<Allergen>();
         if (!this.allergen.Contains(newAllergen))
            this.allergen.Add(newAllergen);
      }
      
      /// <summary>
      /// Remove an existing Allergen from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAllergen(Allergen oldAllergen)
      {
         if (oldAllergen == null)
            return;
         if (this.allergen != null)
            if (this.allergen.Contains(oldAllergen))
               this.allergen.Remove(oldAllergen);
      }
      
      /// <summary>
      /// Remove all instances of Allergen from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAllergen()
      {
         if (allergen != null)
            allergen.Clear();
      }
   
   }
}