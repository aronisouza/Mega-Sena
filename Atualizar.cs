using System.Data.OleDb;

namespace Mega_Sena
{
    class Atualizar : Conexao
    {
        private string _sqlText;
        private string _tabela;
        private int _id;
        private string[] _syntax;
        private string _sets;
        private OleDbConnection _conn;
        private int _retorno = 0;

        // -- PUBLICOS
        public void ExeAtualizar(string tabela, string[] syntax, int id)
        {
            _tabela = tabela;
            _syntax = syntax;
            _id = id;
            GetSyntax();
            Executar();
        }

        public int GetResult()
        {
            return _retorno;
        }

        // -- PRIVADOS
        private void GetSyntax()
        {
            _sets = string.Empty;
            for (int i = 0; i < _syntax.Length; i++)
            {
                string[] s = _syntax[i].Split('=');
                _sets = (i < _syntax.Length - 1) ? _sets + s[0] + "=@" + s[0] + ", " : _sets + s[0] + "=@" + s[0];
            }
            _sqlText = "UPDATE " + _tabela + " SET " + _sets + " WHERE Concurso=@Concurso";
        }

        private void Executar()
        {
            _conn = GetConexao();
            using (OleDbCommand cmd = new OleDbCommand(_sqlText, _conn))
            {
                try
                {
                    _conn.Open();
                    for (int i = 0; i < _syntax.Length; i++)
                    {
                        string[] s = _syntax[i].Split('=');
                        if (s[0] == "Credito")
                        { cmd.Parameters.AddWithValue("@" + s[0], decimal.Parse(s[1])); }
                        else { cmd.Parameters.AddWithValue("@" + s[0], s[1]); }
                    }
                    cmd.Parameters.AddWithValue("@Concurso", _id);
                    _retorno = cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
                finally
                {
                    _conn.Close();
                }
            }
        }

    }
}
