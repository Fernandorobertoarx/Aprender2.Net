using System;
using System.ComponentModel.DataAnnotations;

namespace Aprender2.Net.Api.Dominio.Entidades
{
    public abstract class BaseEntidade
    {
        [Key]
        public int Id { get; set; }

        private DateTime? dataCriado;

        public DateTime? DataCriado { get => this.dataCriado; set { this.dataCriado = (value == null ? DateTime.UtcNow : value); } }

        public DateTime? DataModificado { get; set; }
    }
}
