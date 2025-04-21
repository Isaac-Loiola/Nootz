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
        public Note(string texto)
        {
            Texto = texto;
        }

        /// <summary>
        /// Adiciona uma nota ao banco de dados.
        /// Propriedades necessárias para adionar são: Texto e numero do Painel.
        /// </summary>
        public void Adicionar()
        {
            Note note = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update notes set ativo = 0 where painel = {Painel}";
            cmd.ExecuteNonQuery();


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into notes(texto, painel) values('{Texto}', {Painel})";
            cmd.ExecuteNonQuery();

            // Intânciando a propriedade Id para a nota!
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select last_insert_id()";
            Id = int.Parse(cmd.ExecuteScalar().ToString());

            // Intânciando a propriedade Ativo para a nota!
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select ativo from notes where id = {Id}";
            Ativo = Convert.ToBoolean(cmd.ExecuteScalar());

            // Intânciando a propriedade DataCriacao para a nota!
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select data_criacao from notes where id = {Id}";
            DataCriacao = Convert.ToDateTime(cmd.ExecuteScalar());
        }
       
        /// <summary>
        /// Método BuscarRegistro busca no banco de dados um registro com o painel 
        /// referenciado no parâmetro, e que esteja ativo.
        /// </summary>
        /// <param name="painel"></param>
        /// <returns></returns>
        public static String BuscarRegistro(int painel)
        {   
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select texto from notes where painel = {painel} and ativo = 1";
            return Convert.ToString(cmd.ExecuteScalar()); 
        }

        /// <summary>
        /// Método excluir desativo o registro para não receber mais alterações.
        /// </summary>
        /// <param name="painel"></param>
        public static void Excluir(int painel)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update notes set ativo = 0 where painel = {painel} ";
            cmd.ExecuteNonQuery();
        }

    }
}