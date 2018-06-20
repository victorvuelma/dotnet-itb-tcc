using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilPedido
    {

        public static void inserirItem(int codPedido, clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            objItem.CodPedido = codPedido;
            objItem.gravar();

            foreach (clnItemIngrediente objIngrediente in objItemIngredientes)
            {
                objIngrediente.CodItem = objItem.Cod;
                objIngrediente.gravar();
            }
        }

    }
}
