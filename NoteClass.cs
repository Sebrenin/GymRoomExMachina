using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GymRoomExMachina
{
    public class NoteClass
    {
        // Identificador único para cada nota
        public Guid Id { get; set; } = Guid.NewGuid();

        // Título de la nota
        public string Title { get; set; } = "Tittle";

        // Contenido completo de la nota
        public string Content { get; set; } = " ";

        // Fecha de creación
        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Fecha de última modificación
        public DateTime LastModified { get; set; } = DateTime.Now;

        [JsonIgnore]
        public bool IsEmptyDraft => string.IsNullOrWhiteSpace(Title) && string.IsNullOrWhiteSpace(Content);
    }
}
