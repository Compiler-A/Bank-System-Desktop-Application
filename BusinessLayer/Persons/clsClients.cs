using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsClients 
    {
        private enum enMode { enUpdate = 0, enAdd = 1 };
        private enMode Mode = new enMode();

        public int ClientID { get; set; }
        public string ClientName { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string Email { get; set; }
         public int Phone { get; set; }
        public string PinCode { get; set; }
        public float Ballance { get; set; }

        public clsClients()
        {
            this.ClientID = -1;
            this.ClientName = "";
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = 0;
            this.PinCode = "";
            this.Ballance = 0;
            Mode = enMode.enAdd;
        }

        private clsClients(int ClientsID, string UserName, string FirstName, string LastName, string Email
            , int Phone, string PinCode, float Ballance)
        {
            this.ClientID = ClientsID;
            this.ClientName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.PinCode = PinCode;
            this.Ballance = Ballance;
            Mode = enMode.enUpdate;
        }
        static public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            dt = clsDataClients.GetAllClients();
  
            if (dt.Columns.Count == 0)
            {
                return dt;
            }
            DataRow[] Resulted = dt.Select("ClientID>0");
            
            foreach (var ResultedRow in Resulted)
            {
                ResultedRow["PinCode"] = clsSetting.Decryption(ResultedRow["PinCode"].ToString());
            }
            return dt;
        }

        static public float GetTotalBallance()
        {
            return clsDataClients.GetTotalBallance();
        }
        static public clsClients FindClientByClientName(string ClientName)
        {
            int ClientID = 0, Phone = 0; float Ballance = 0;
            string FirstName = "", LastName = "", Email = "", PinCode = "";
            if (clsDataClients.FindClientByClientName(ref ClientID, ClientName, ref FirstName, ref LastName,
                ref Email, ref Phone, ref PinCode, ref Ballance))
            {
                return new clsClients(ClientID, ClientName, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(PinCode), Ballance);
            }
            return new clsClients(ClientID, "", FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(PinCode), Ballance);
        }
        static public clsClients FindClientByClientID(int ClientID)
        {
            string ClientName = "", FirstName = "", LastName = "", Email = "", Password = "";
            float Ballance = 0;
            int Phone = 0;
            if (clsDataClients.FindClient(ClientID, ref ClientName, ref FirstName, ref LastName, ref Email, ref Phone,
                ref Password, ref Ballance))
            {
                return new clsClients(ClientID, ClientName, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Ballance);
            }
            return new clsClients(0, ClientName, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Ballance);

        }

        static public bool DeleteClientByClientID(int ClientID)
        {
            return clsDataClients.DeleteCLient(ClientID);
        }


        private bool _AddUser()
        {
            return clsDataClients.AddNewClient(this.ClientName, this.FirstName, this.LastName,
                this.Email, this.Phone, this.PinCode, this.Ballance);
        }


        private bool _UpdateUser()
        {

            return clsDataClients.UpdateClient(this.ClientID, this.ClientName, this.FirstName, this.LastName,
                this.Email, this.Phone, this.PinCode, this.Ballance);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAdd:
                    if (_AddUser())
                    {
                        Mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateUser();

            }
            return true;
        }

        static public bool CheckedUser(int ID)
        {
            return clsDataClients.CheckedUser(ID);
        }

        static public bool ChangedBallance(string ClientName ,  float Ballance)
        {
            return clsDataClients.ChangedBallance(ClientName, Ballance);
        }

        static public bool NotUniqueClientName(string ClientName, int ID)
        {
            return clsDataClients.NotUniqueClient(ClientName, ID);
        }

    }
}
