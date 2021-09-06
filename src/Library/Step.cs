//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID.Library
{
        /*
        Aplicamos los patrones Expert y SRP para asignar la responsabilidad de calcular el subtotal,
         ya que la clase step contiene los productos, la cantidad, los costos, el equipamiento y el tiempo utilizado.
      */
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    
        public double SubTotal {
            get 
            {
                return this.Quantity * this.Input.UnitCost + this.Equipment.HourlyCost * this.Time ;

            }
        }
    }
}