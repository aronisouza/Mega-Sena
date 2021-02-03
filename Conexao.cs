using System.Data.OleDb;

namespace Mega_Sena
{
    class Conexao
    {
        private OleDbConnection conn = null; 

        public OleDbConnection GetConexao()
        {
         
            Connection();
            return conn;
        }

        private void Connection()
        {
            if (conn == null)
            {
                //conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\CSharp\MSena\Mega Sena\bin\Debug\Sena.mdb");//Sena
                //***** Pra teste
                conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\CSharp\MSena\Mega Sena\bin\Debug\Teste.mdb");//Sena
            }
        }
    }
}
