using System;
using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
	public partial class Input_Email_Dialog : Window
	{
		// Sid Ahmed commented that because they are not used
		// public bool sortie = false;
		// public bool aff = false;
		public double mo = 0;
		WpfApp2.pret_remboursable pr;

		//Class principale de la fenetre d'ajout de mail de l'employé

		public Input_Email_Dialog(WpfApp2.pret_remboursable p, double m, string question, string defaultAnswer = "")
		
		{
			InitializeComponent();			
			lblQuestion.Content = question;
			txtAnswer.Text = defaultAnswer;
			mo = m;
			pr = p;
		}


		//methodes de manupulation de l'interface
		private void btnDialogOk_Click(object sender, RoutedEventArgs e)
		{

			pr.Employé.Email = txtAnswer.Text;
			WpfApp2.responsable.pile_modifications.Add(new WpfApp2.Modification(1, pr.Employé.Cle));

			WpfApp2.responsable.Envoi_mail(pr, mo);
			// Sid Ahmed commented that because they are not used
			// aff = true;
			this.Close();
		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{
			txtAnswer.SelectAll();
			txtAnswer.Focus();
		}
		
		// Sid Ahmed Commented it because it's not used 
		// public string Answer
		// {
		// 	get { return txtAnswer.Text; }
		// }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// Sid Ahmed commented that because they are not used
			// this.sortie = true;
			this.Close();
		}
	}
}
