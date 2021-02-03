using System.Data;
using System.Data.OleDb;

namespace Mega_Sena
{
    class Selecionar : Conexao
    {
        private string _sqlTxt;
        private string _tabela;
        private string[] _colunas;
        private DataTable _dt = null;
        private string[] _condicoes;
        private string _colunasSyntax;
        private string _condicao;
        private OleDbConnection _conn;

        // -- PUBLICOS
        public void ExeSelecionar(string tabela, string[] colunas = null, string[] condicoes = null)
        {
            _tabela = tabela;
            _colunas = colunas;
            _condicoes = condicoes;
            GetSyntax();
            Execute();
        }

        public DataTable GetTabela()
        {
            return _dt;
        }

        public int GetRows()
        {
            int i = _dt.Rows.Count;
            return i;
        }

        // -- PRIVADOS
        private void GetSyntax()
        {
            // -- Limpa a strings caso tenha mais de 1 consulta por execução do Programa
            _condicao = string.Empty;
            _colunasSyntax = string.Empty;

            if(_colunas == null)
            {
                string[] dd = { "*" };
                _colunas = dd;
            }

            for (int i = 0; i < _colunas.Length; i++)
            {
                _colunasSyntax = (i < (_colunas.Length - 1)) ? _colunasSyntax + _colunas[i] + ", " : _colunasSyntax + _colunas[i];
            }

            // - Pegando as condições
            // - Para não ter um condição de pesquisa deixar [null] na passagem de parametros
            // - na chamada do função(Método) na ação principal
            if (_condicoes == null)
            {
                _sqlTxt = "SELECT " + _colunasSyntax + " FROM " + _tabela + " ORDER BY concurso DESC";
            }
            else
            {
                for (int i = 0; i < _condicoes.Length; i++)
                {
                    // = usado pra procurar uma palavra inteira aroni = aroni 
                    if (_condicoes[i].Contains("=") == true)
                    {
                        string[] col = _condicoes[i].Split('=');
                        _condicao = (i < _condicoes.Length - 1) ? _condicao + col[0] + "=@" + col[0] + " OR " : _condicao + col[0] + "=@" + col[0];
                    }
                    // : usado pra procurar parte de uma palavra exemplo aroni = ron 
                    else if(_condicoes[i].Contains(":") == true)
                    {
                        string[] col = _condicoes[i].Split(':');
                        _condicao = (i < _condicoes.Length - 1) ? _condicao + col[0] + " LIKE @" + col[0] + " OR " : _condicao + col[0] + " LIKE @" + col[0];
                    }
                    // < usado pra pesquisa exata
                    else if (_condicoes[i].Contains("<") == true)
                    {
                        string[] col = _condicoes[i].Split('<');
                        _condicao = (i < _condicoes.Length - 1) ? _condicao + col[0] + " =@" + col[0] + " AND " : _condicao + col[0] + " =@" + col[0];
                    }
                }
                _sqlTxt = "SELECT " + _colunasSyntax + " FROM " + _tabela + " WHERE " + _condicao;
            }
        }

        private void Execute()
        {
            _conn = GetConexao();
            using (OleDbCommand cmd = new OleDbCommand(_sqlTxt, _conn))
            {
                try
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    if (_condicoes != null)
                    {
                        for (int i = 0; i < _condicoes.Length; i++)
                        {
                            if (_condicoes[i].Contains("=") == true)
                            {
                                string[] s = _condicoes[i].Split('=');
                                cmd.Parameters.AddWithValue("@" + s[0], s[1]);
                            }
                            else if (_condicoes[i].Contains(":") == true)
                            {
                                string[] s = _condicoes[i].Split(':');
                                cmd.Parameters.AddWithValue("@" + s[0], s[1]);
                            }
                            else if (_condicoes[i].Contains("<") == true)
                            {
                                string[] s = _condicoes[i].Split('<');
                                cmd.Parameters.AddWithValue("@" + s[0], s[1]);
                            }
                        }
                    }
                    adp.Fill(dt);
                    _dt = dt;
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
