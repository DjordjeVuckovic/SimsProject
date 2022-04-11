// File:    AppointmentService.cs
// Author:  nsred
// Created: Thursday, April 7, 2022 6:13:48 PM
// Purpose: Definition of Class AppointmentService

using System;
using System.Collections.Generic;
using TechHealth.Model;
using TechHealth.Repository;

namespace TechHealth.Service
{
   public class AppointmentService
   {
      public Appointment GetById(string idAppointment)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetAll()
      {
        return AppointmentRepository.Instance.DictionaryValuesToList();
      }
      
      public bool Create(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public bool Update(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(string idAppointment)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetByDoctorId(string doctorId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetByPatientId(string patientId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetByRoomId(string roomId)
      {
         throw new NotImplementedException();
      }
   
   }
}