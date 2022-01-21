namespace WpfApp2.Prets_Factory_Pattern
{
    abstract public class PretsFactory
    {
        abstract public Pret creer_pret(string choix);
    }
}