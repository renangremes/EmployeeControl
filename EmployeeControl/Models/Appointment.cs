﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeControl.Models
{
    public class Appointment
    {
        //Atributos
        public int ID { get; private set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime hour { get; set; }
        public Employees Employees { get; set; }

        //Construtores
        public Appointment()
        {

        }

        public Appointment(int id, DateTime date, DateTime hour, Employees employee)
        {
            ID = id;
            this.date = date;
            this.hour = hour;
            Employees = employee;
        }
    }
}
