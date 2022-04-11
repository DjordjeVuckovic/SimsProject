// File:    Address.cs
// Author:  djord
// Created: Monday, March 28, 2022 9:00:05 AM
// Purpose: Definition of Class Address

using System;
using PostSharp.Patterns.Model;
using TechHealth.Controller;
namespace TechHealth.Model
{
   [NotifyPropertyChanged] 
   public class Address
   {
      public string City { get; set; }
      public string StreetNumber{ get; set; }
      public string Country{ get; set; }
      public string Street{ get; set; }
      public int Postcode{ get; set; }
   
   }
}