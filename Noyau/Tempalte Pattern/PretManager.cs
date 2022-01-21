using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System.Net.Mail;
using System.Windows;
using System.Security.RightsManagement;
using System.Reflection;
using WpfApp2.Prets_Factory_Pattern;

namespace WpfApp2.Tempalte_Pattern
{
    public abstract class PretManager
    {
        protected PretsFactory factory;


        abstract public void filtrer_par_date_demande_inf(bool date, DateTime d_inf);
        abstract public void filtrer_par_date_demande_max(bool date, DateTime d_sup);
        // + autres methodes de filtrage commune ...
        abstract public void filtrer_special(); // elle va contenir les methodes exclusives de pret remboursable/non remboursable  de filtrage

        
        // TEMPLATE METHOD
        public void recherche_par_criters(DateTime d_inf , DateTime d_sup)
        {
            filtrer_par_date_demande_inf(true , d_inf);
            filtrer_par_date_demande_max(true, d_sup);
            // + l'appelation d'autres methodes de filtrage commune
            filtrer_special();
        }
    }
}