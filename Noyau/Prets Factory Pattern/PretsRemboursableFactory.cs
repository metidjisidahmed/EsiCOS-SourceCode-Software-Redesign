namespace WpfApp2.Prets_Factory_Pattern
{
    public class PretsRemboursableFactory : PretsFactory
    {
        public override Pret creer_pret(string choix)
        {
            switch (choix)
            {
                case "Social":
                    return new Pret_Social();
                case "Electromenager":
                    return new Pret_Electromenager_Non_Remborsable();
                default:
                    return null;
            }
        }
    }
}