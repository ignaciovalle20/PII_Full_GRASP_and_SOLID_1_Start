//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }
      /*
        Aplicamos los patrones Expert y SRP para asignar la responsabilidad de calcular el total,
         ya que la clase receta contiene los pasos, y esta a su vez contiene el costo Subtotal de cada paso.
      */
        public double GetProductionCost()
        {
                double result = 0;
                foreach (Step step in this.steps)
                {
                    result = result + step.SubTotal;
                }

                return result;
        }
       
        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Costo total {this.GetProductionCost()}");
        }
    }
}