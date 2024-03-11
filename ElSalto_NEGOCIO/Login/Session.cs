using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO.Login
{
    public class Session
    {

        public bool IsValidLogin(string username, string password)
        {
            bool res;
            try
            {
                var hash = CommonBC.PlantaModelo.spLogin(username).First();


                if (hash != string.Empty)
                {

                    //Salt heleper 

                    bool temp = Helpers.SALT_Helper.ValidateSaltyPassword(password, hash);
                    if (temp)
                        res = true;
                    else
                        res = false;
                }
                else
                {
                    res = false;
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
    }
}
