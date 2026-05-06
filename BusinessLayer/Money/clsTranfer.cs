using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsTranfer
    {

        static private bool _isTranfer(string sClient, string dClient,
            ref clsClients sClients, ref clsClients dClients)
        {
            sClients = clsClients.FindClientByClientName(sClient);
            dClients = clsClients.FindClientByClientName(dClient);
            if (sClients.ClientID != 0 && dClients.ClientID != 0)
            {
                return true;
            }
            return false;
        }

        

        static public bool AddTransfer(string sClient, string dClient, float Amount, string userName)
        {
            float sBallance = 0, dBallance = 0;
            clsClients sClients = new clsClients(), dClients = new clsClients();
            if (!_isTranfer(sClient, dClient, ref sClients, ref dClients))
            {
                return false;
            }
            sBallance = sClients.Ballance - Amount;
            dBallance = dClients.Ballance + Amount;

            if (clsDataTranfer.AddTransferData(sClient, dClient, Amount,
                sBallance, dBallance, userName))
            {
                clsClients.ChangedBallance(sClient, -Amount);
                clsClients.ChangedBallance(dClient, +Amount);
                return true;
            }


            return false;
        }

        static public DataTable GetAllTransfer()
        { 
            
            
             return clsDataTranfer.GetAllTransfer();
           
        }
    }
}
