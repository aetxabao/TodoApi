namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Identificador de la tarea.
        /// </summary>
        /// <example>1</example>
        public long Id { get; set; }
        /// <summary>
        /// Nombre de la tarea.
        /// </summary>
        /// <example>walk dog</example>
        public string Name { get; set; }
        /// <summary>
        /// Si la tarea está realizada o no.
        /// </summary>
        /// <example>true</example>
        public bool IsComplete { get; set; }
    }
}