using BurgerShack.Common;

namespace BurgerShack.Web.Bll
{
    public class ClienteBLL
    {

        public bool autenticado()
        {
            return true;
        }

        public int obterCodCliente()
        {
            return 1;
        }

        public clnCliente obterCliente()
        {
            return new clnCliente { Cod = obterCodCliente() }.obterPorCod();
        }

    }
}
