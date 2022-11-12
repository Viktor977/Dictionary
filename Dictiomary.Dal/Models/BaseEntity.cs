using System;
using System.ComponentModel.DataAnnotations;

namespace Dictionary.Dal.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [MaxLength(150,ErrorMessage ="Maximum the length this word is 150 characters")]
        public string Word { get; set; }
        public string Examples { get; set; }
    }
}
