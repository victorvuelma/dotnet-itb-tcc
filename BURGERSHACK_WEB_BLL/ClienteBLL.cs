using BurgerShack.Common;

namespace BurgerShack.Web.Bll
{
    public class ClienteBLL
    {

        public clnCliente obterCliente()
        {
            return new clnCliente { Cod = 1 }.obterPorCod();
        }

    }
}
