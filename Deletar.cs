﻿using System;
using System.Data.OleDb;

namespace Mega_Sena
{
    class Deletar : Conexao
    {
        // - Base
        private string _tabela;
        private int _result = 0;
        private OleDbConnection _conn;
        private string _sqltxt;

        // - Alternativas
        private int _valorId;
        private string[] _outraCondicao;
        private string _outraCondicaoSyntax;

        //----------------
        // Metodos PUBLIC
        //----------------
        public void ExeDelete(string tabela, string[] outraCondicao = null, int valorId = 0)
        {
            _tabela = tabela;
            _outraCondicao = outraCondicao;
            _valorId = valorId;
            _outraCondicaoSyntax = string.Empty;
            _sqltxt = _outraCondicao != null ? GetSyntax() : "DELETE FROM " + _tabela + " WHERE Id=@Id";
            Execulte();
        }

        public int GetResult()
        {
            return _result;
        }

        //-----------------
        // Metodos PRIVATE
        //-----------------
        private string GetSyntax()
        {
            for (int i = 0; i < _outraCondicao.Length; i++)
            {
                string[] s = _outraCondicao[i].Split('=');
                _outraCondicaoSyntax = (i < (_outraCondicao.Length - 1)) ? _outraCondicaoSyntax + s[0] + "=@" + s[0] + " AND " : _outraCondicaoSyntax + s[0] + "=@" + s[0];
            }
            return _sqltxt = "DELETE FROM " + _tabela + " WHERE " + _outraCondicaoSyntax;
        }

        private void Execulte()
        {
            _conn = GetConexao();
            using (OleDbCommand cmd = new OleDbCommand(_sqltxt, _conn))
            {
                if (_outraCondicao == null)
                {
                    cmd.Parameters.AddWithValue("@Id", +_valorId);
                }
                else
                {
                    for (int i = 0; i < _outraCondicao.Length; i++)
                    {
                        string[] s = _outraCondicao[i].Split('=');
                        cmd.Parameters.AddWithValue("@" + s[0], s[1]);
                    }
                }
                try
                {
                    _conn.Open();
                    _result = cmd.ExecuteNonQuery();
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
