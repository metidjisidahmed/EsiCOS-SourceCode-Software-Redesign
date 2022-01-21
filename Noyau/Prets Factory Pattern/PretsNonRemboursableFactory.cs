namespace WpfApp2.Prets_Factory_Pattern
{
    public class PretsNonRemboursableFactory : PretsFactory
    {
        public override Pret creer_pret(string choix)
        {
            switch (choix)
            {
                case "Don":
                    return new Pret_Don();
                case "Electromenager":
                    return new Pret_Electromenager_Non_Remborsable();
                default:
                    return null;
            }
        }
    }
}