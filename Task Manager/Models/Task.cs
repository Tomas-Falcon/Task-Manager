using System;
using System.Collections.Generic;

namespace Task_Manager.Models
{
    // Clase base para las tareas
    public abstract class Task
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? FinalizationDate { get; set; }
        public Status TaskStatus { get; set; }

        // Enumeración para el estado de la tarea
        public enum Status
        {
            Iniciado,
            Pausado,
            Completado
        }

        // Constructor por defecto
        protected Task() { }

        // Constructor con parámetros
        protected Task(string name, string? description)
        {
            Name = name;
            Description = description;
            TaskStatus = Status.Iniciado;
        }

      
    }

    // Clase derivada para tareas con un período concreto
    public class PeriodicTask : Task
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public PeriodicTask(string name, string? description, DateTime startDate, DateTime endDate)
            : base(name, description)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

       
    }

    // Clase derivada para tareas sin fecha de caducidad
    public class OngoingTask : Task
    {
        public OngoingTask(string name, string? description)
            : base(name, description)
        {
        }

        
    }

    // Clase derivada para tareas con checklist
    public class ChecklistTask : Task
    {
        public List<string> ChecklistItems { get; set; } = new List<string>();

        public ChecklistTask(string name, string? description, List<string> checklistItems)
            : base(name, description)
        {
            ChecklistItems = checklistItems;
        }

      
    }

    // Clase derivada para tareas de compra
    public class ShoppingTask : Task
    {
        public List<string> ShoppingList { get; set; } = new List<string>();

        public ShoppingTask(string name, string? description, List<string> shoppingList)
            : base(name, description)
        {
            ShoppingList = shoppingList;
        }

      
    }
}
