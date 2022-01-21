using System;
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
    public class PretRemboursableManager : PretManager , Iterator.Iterator
    {
        List<PretRemboursable> prets;
        int iter_position = 0;
        


        // CONSTRUCTOR
        public PretRemboursableManager() : base()
        {
            this.factory = new PretsRemboursableFactory();
        }
        public override void filtrer_par_date_demande_inf(bool date, DateTime d_inf)
        {
            // le corps du méthode filtrer_par_date_demande_inf_rem()
        }

        public override void filtrer_par_date_demande_max(bool date, DateTime d_sup)
        {
            // le corps du méthode filtrer_par_date_demande_sup_rem()

        }
        
        // METHODES DE FILTRAGE EXCLUSIVE POUR LES PRETS REMBOURSBALES 
        public void filtrer_par_durée_min()
        {
            // le corps du méthode filtrer_par_durée_min_rem()
        }
        
        public void filtrer_par_durée_max(){
            // le corps du méthode filtrer_par_durée_max_rem()
        }            

        // LE CORPS DE FILTRE SPECIAL POUR PRETS REMBOURSABLES
        public override void filtrer_special()
        {
            this.filtrer_par_durée_max();
            this.filtrer_par_durée_min();
        }
        
        // PRETS  REMBOURSABLE ITERATOR 


        public bool encore()
        {
            if (this.iter_position >= this.prets.Count )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        

        public object suivant()
        {
            Pret pret = this.prets.ElementAt(this.iter_position);
            this.iter_position++;
            return pret;
        }
    }
}