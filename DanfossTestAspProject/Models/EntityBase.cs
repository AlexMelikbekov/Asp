using System;
using System.ComponentModel.DataAnnotations;

namespace DanfossTestAspProject.Models
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Базовый класс для бд. 
        /// </summary>
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public int Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
