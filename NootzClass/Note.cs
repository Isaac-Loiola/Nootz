using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NootzClass
{
    public class Note
    {

        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Ativo { get; set; }
        public int Painel { get; set; }
        public DateTime DataCriacao { get; set; }
        
        //Construrores

        public Note()
        {

        }
        public Note(int id, string texto, bool ativo, int painel, DateTime dataCriacao)
        {
            Id = id;
            Texto = texto;
            Ativo = ativo;
            Painel = painel;
            DataCriacao = dataCriacao;
        }

        public Note(string texto, int painel)
        {
            Texto = texto;
            Painel = painel;
        }
        public Note(int painel)
        {
            Painel = painel;
        }

        public void Adicionar()
        {
            Note note = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert into notes(texto, painel) values('{Texto}', {Painel})";
            cmd.ExecuteNonQuery();

            // Intânciando a propriedade Id para a nota!
            cmd.CommandText = "select last_insert_id()";
            Id = int.Parse(cmd.ExecuteScalar().ToString());

            // Intânciando a propriedade Ativo para a nota!
            cmd.CommandText = $"select ativo from notes where id = {Id}";
            Ativo = Convert.ToBoolean(cmd.ExecuteScalar());

            // Intânciando a propriedade DataCriacao para a nota!
            cmd.CommandText = $"select data_criacao from notes where id = {Id}";
            DataCriacao = Convert.ToDateTime(cmd.ExecuteScalar());
        }
       
        public void BuscarRegistro(int painel)
        {
            Note note = new();
            if (note.Ativo)
            {
                var cmd = Banco.Abrir();

            }
        }
    }
}