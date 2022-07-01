using System;
using System.Collections.Generic;

namespace TP9.Models
{
    public static class Pizzeria
    {
        private static int _CantidadPizzas=0;
        private static List<ingredientes> _ListaIngredientes = new List<ingredientes>();
        
        private static List<Pizza> _ListaPizzas = new List<Pizza>();

        public static List<ingredientes> ListarIngredientes(){
            _ListaIngredientes.Clear();

            ingredientes ing = new ingredientes(1,"Oregano", "Oregano.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(2,"Jamón", "Jamón.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(3,"Muzzarella", "Muzzarella.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(4,"Champiñones", "Champiñones.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(5,"Piña", "Piña.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(6,"Cebolla", "Cebolla.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(7,"Huevo", "Huevo.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(8,"Morrón", "Morrón.jpg");
            _ListaIngredientes.Add(ing);
            ing = new ingredientes(9,"Choclo", "Choclo.jpg");
            _ListaIngredientes.Add(ing);
            return _ListaIngredientes;
        }
        
        public static List <Pizza> ListarPizzas(){
            return _ListaPizzas;
        }

        public static void AgregarPizza(Pizza UnaPizza){
            _ListaPizzas.Add(UnaPizza);
        }

        public static bool EliminarPizza(Pizza UnaPizza){
            if(_ListaPizzas.Contains(UnaPizza)){
            _ListaPizzas.Remove(UnaPizza);
            }
            return true;
        }

        public static int devolverId(){
            _CantidadPizzas++;
            return _CantidadPizzas;
        }

        public static List<ingredientes> DevolverIngredientes(List<int> Lista){
            List<ingredientes> PizzaIngredientes = new List<ingredientes>();
            foreach (int Id in Lista){
                foreach (ingredientes ing in _ListaIngredientes){
                    if(Id == ing.IdIngredientes){
                        PizzaIngredientes.Add(ing);
                    }
                }
            }
            return PizzaIngredientes;   
        }




    
        

    }
}